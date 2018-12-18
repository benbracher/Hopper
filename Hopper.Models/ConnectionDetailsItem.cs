using Hopper.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hopper.Models
{
    public class ConnectionDetailsItem
    {
        public int RideId { get; set; }
        public int TransportId { get; set; }
        public IEnumerable<TransportListItem> Transports { get; set; }

        public RideInfo Ride { get; set; }
        public TransportInfo Transport { get; set; }


    }
}
