﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hopper.Models
{
    public class RideInfo
    {
        public int RideId { get; set; }
        public Guid OwnerId { get; set; }
        public int DistanceLength { get; set; }
        public double RideCost { get; set; }
        public string StartAddress { get; set; }
        public string StartCity { get; set; }
        public string StartState { get; set; }
        public string EndAddress { get; set; }
        public string EndCity { get; set; }
        public string EndState { get; set; }
        public DateTime DistanceTime { get; set; }
        public DateTime RideDate { get; set; }
    }
}
