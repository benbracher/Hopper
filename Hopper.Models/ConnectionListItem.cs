using Hopper.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hopper.Models
{
    public class ConnectionListItem
    {
        public IEnumerable<TransportListItem> Transports { get; set; }
        public int RideId { get; set; }
    }
}
