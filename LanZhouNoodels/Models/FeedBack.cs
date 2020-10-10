using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanZhouNoodels.Models
{
    public class FeedBack
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreateDateUtc { get; set; }
        public string Message { get; set; }
    }
}
