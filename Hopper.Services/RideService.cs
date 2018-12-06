using Hopper.Data;
using Hopper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hopper.Services
{
    public class RideService
    {
        private readonly Guid _userId;

        public RideService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateRide(RideCreate model)
        {
            var entity =
                new Ride()
                {
                    OwnerId = _userId,
                    StartAddress = model.StartAddress,
                    StartCity = model.StartCity,
                    StartState = model.StartState,
                    EndAddress = model.EndAddress,
                    EndCity = model.EndCity,
                    EndState = model.EndState,
                    RideDate = model.RideDate
                };
            entity.DistanceTime = DateTime.Now;

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Rides.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<RideList> GetRides()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Rides
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                            e =>
                                new RideList
                                {
                                    RideId = e.RideId,
                                    StartAddress = e.StartAddress,
                                    StartCity = e.StartCity,
                                    StartState = e.StartState,
                                    EndAddress = e.EndAddress,
                                    EndCity = e.EndCity,
                                    EndState = e.EndState,
                                    RideDate = e.RideDate
                                }
                         );

                return query.ToArray();
            }
        }
    }
}
