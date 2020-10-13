using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanZhouNoodleCJ.Modles;

namespace LanZhouNoodleCJ.ViewModles
{
    public class HomeViewModle
    {
        public IEnumerable<Noodle> Noodles { get; set; }
        public IEnumerable<FeedBack> FeedBacks { get; set; }
    }
}
