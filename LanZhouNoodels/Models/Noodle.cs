﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanZhouNoodels.Models
{
    public class Noodle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StrotDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImgUrl { get; set; }
    }
}
