using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanZhouNoodels.Models
{
    public class FeedBackRepository : IFeedBackRepository
    {
        private readonly AppDBContext _context;
        public FeedBackRepository(AppDBContext context) {
            _context = context;
        }
        public void AddFeedBack(FeedBack feedBack)
        {
            _context.FeedBacks.Add(feedBack);
            _context.SaveChanges();
        }

        public IEnumerable<FeedBack> GetFeedBacks()
        {
            return _context.FeedBacks;
        }
    }
}
