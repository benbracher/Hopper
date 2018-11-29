using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hopper.Data
{
    public enum AnimalType {Toad,Kangaroo,Rabbit,Grasshopper,Spider}

    public class Transport
    {
        [Key]
        public int TransportId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public AnimalType TransportAnimal { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Color { get; set; }
    }

    
}
