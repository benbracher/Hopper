using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hopper.Models
{
    public class ConnectionCreate
    {
        public int RideId { get; set; }
        public int TransportId { get; set; }

        public RideInfo Ride { get; set; }
        public TransportInfo Transport { get; set; }
    }
}
