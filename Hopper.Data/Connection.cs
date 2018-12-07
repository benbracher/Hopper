using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hopper.Data
{
    public class Connection
    {
        [Key]
        public int ConnectionId { get; set; }

        public int TransportId { get; set; }
        public int RideId { get; set; }

        public virtual Transport Transport { get; set; }
        public virtual Ride Ride { get; set; }
    }
}
