using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hopper.Models
{
    public class RideCreate
    {
        public string StartAddress { get; set; }

        public string StartCity { get; set; }

        public string StartState { get; set; }

        public string EndAddress { get; set; }

        public string EndCity { get; set; }

        public string EndState { get; set; }

        [DataType(DataType.Date)]
        public DateTime RideDate { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
