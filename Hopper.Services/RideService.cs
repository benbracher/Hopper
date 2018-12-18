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

        public ConnectionDetailsItem GetRide()
        {
            using (var ctx = new ApplicationDbContext())
            {
                //Get RideInfoList
                var rideInfoList =
                    ctx
                        .Rides
                        .Select(
                            e =>
                                new RideInfo
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
                        ).ToList();

                //Check if doesn't have ride, returns empty model if n/a
                if (rideInfoList.Count == 0)
                {
                    return new ConnectionDetailsItem();
                }

                //Grab ride from list, check connection table
                var rideInfo = rideInfoList[0];
                var connectionInfoList =
                    ctx
                        .Connections
                        .Where(c => c.RideId == rideInfo.RideId)
                        .ToList();

                var thing = connectionInfoList[0].TransportId;

                //If connection, get transport and add to model, return model
                if (connectionInfoList.Count == 1)
                {
                    var transport =
                        ctx
                            .Transports
                            .Single(t => t.TransportId == thing);

                    var transportInfo = new TransportInfo
                    {
                        TransportId = transport.TransportId,
                        //todo: changed
                        TransportAnimal = transport.TransportAnimal.ToString(),
                        Age = transport.Age,
                        Color = transport.Color,
                        OwnerId = transport.OwnerId
                    };

                    return new ConnectionDetailsItem
                    {
                        Ride = rideInfo,
                        Transport = transportInfo,
                    };
                }

                return new ConnectionDetailsItem
                {
                    Ride = rideInfo,
                    RideId = rideInfo.RideId

                };
            }
        }
    }
}
