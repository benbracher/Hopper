using Hopper.Data;
using Hopper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hopper.Services
{
    public class TransportService
    {
        private readonly Guid _userId;

        public TransportService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateTransport(TransportCreate model)
        {
            var entity =
                new Transport()
                {
                    OwnerId = _userId,
                    TransportAnimal = model.TransportAnimal,
                    Age = model.Age,
                    Color = model.Color
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Transports.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<TransportListItem> GetTransports()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Transports
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                            e =>
                                new TransportListItem
                                {
                                    TransportId = e.TransportId,
                                    TransportAnimal = e.TransportAnimal,
                                    Age = e.Age,
                                    Color = e.Color
                                }
                        );

                return query.ToArray();
            }
        }

        public TransportDetail GetTransportById(int transportId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Transports
                        .Single(e => e.TransportId == transportId && e.OwnerId == _userId);
                return
                    new TransportDetail
                    {
                        TransportId = entity.TransportId,
                        TransportAnimal = entity.TransportAnimal,
                        Age = entity.Age,
                        Color = entity.Color
                    };
            }
        }

        public bool DeleteTransport(int transportId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Transports
                        .Single(e => e.TransportId == transportId && e.OwnerId == _userId);

                ctx.Transports.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
