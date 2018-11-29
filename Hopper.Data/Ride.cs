using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hopper.Data
{
    public class Ride
    {
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public int DistanceLength { get; set; }
        public DateTime DistanceTime { get; set; }
        public DateTime RideDate { get; set; }
    }
}
