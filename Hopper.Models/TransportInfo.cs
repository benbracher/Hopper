using Hopper.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hopper.Models
{
    public class TransportInfo
    {
        public int TransportId { get; set; }
        public Guid OwnerId { get; set; }
        //todo: changed
        public string TransportAnimal { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
    }
}
