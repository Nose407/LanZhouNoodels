using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanZhouNoodels.Models
{
    public interface IFeedBackRepository
    {
        IEnumerable<FeedBack> GetFeedBacks();
        void AddFeedBack(FeedBack feedBack);
    }
}
