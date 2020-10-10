using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanZhouNoodels.Models;

namespace LanZhouNoodels.ViewModels
{
    public class HomeViewModel
    {
        public IList<FeedBack> FeedBacks { get; set; }
        public IList<Noodle> Noodles { get; set; }
    }
}
