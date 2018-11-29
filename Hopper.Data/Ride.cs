using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hopper.Data
{
    public class Ride
    {
        [Key]
        public int RideId { get; set; }

        [Required]
        public string StartLocation { get; set; }

        [Required]
        public string EndLocation { get; set; }

        [Required]
        public int DistanceLength { get; set; }

        [Required]
        public DateTime DistanceTime { get; set; }

        [Required]
        public DateTime RideDate { get; set; }
    }
}
