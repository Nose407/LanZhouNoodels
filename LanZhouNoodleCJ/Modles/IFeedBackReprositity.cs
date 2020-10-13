using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanZhouNoodleCJ.Modles
{
    public interface IFeedBackReprositity
    {
        IEnumerable<FeedBack> GetFeedBacks();

        FeedBack GetFeedById(int id);

        void AddFeedBack(FeedBack feedBack);
    }
}
