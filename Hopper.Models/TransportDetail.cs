﻿using Hopper.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hopper.Models
{
    public class TransportDetail
    {
        public int TransportId { get; set; }
        public AnimalType TransportAnimal { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
    }
}
