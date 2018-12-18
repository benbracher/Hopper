using Hopper.Contracts;
using Hopper.Data;
using Hopper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hopper.Services
{
    public class ConnectionService : IConnectionService
    {
        private readonly Guid _userId;

        public ConnectionService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateConnection(ConnectionCreate model)
        {
            var connection = new Connection
            {
                RideId = model.RideId,
                TransportId = model.TransportId
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Connections.Add(connection);
                return ctx.SaveChanges() == 1;
            }
        }

        public ConnectionDetailsItem GetConnectionById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Connections
                        .Single(e => e.ConnectionId == id);
                    //.Find(id);
                return
                    new ConnectionDetailsItem
                    {
                        TransportId = entity.Transport.TransportId,
                        RideId = entity.Ride.RideId
                    };
            }
        }

        public ConnectionDetailsItem GetPotentialConnectionData(IEnumerable<TransportListItem> transports, RideInfo ride)
        {
            var x =
                new ConnectionDetailsItem
                {
                    Ride = ride,
                    Transports = transports,
                    RideId = ride.RideId

                };
            return x;
        }
    }
}
