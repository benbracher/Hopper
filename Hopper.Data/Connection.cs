using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hopper.Data
{
    public class Connection
    {
        public int ConnectionId { get; set; }
        public int TransportId { get; set; }

        public virtual Transport Transport { get; set; }
    }
}
