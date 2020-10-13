using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanZhouNoodleCJ.Modles
{
    public class Noodle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Introduce { get; set; }
        public decimal Price { get; set; }
        public string ImgUrl { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
