using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanZhouNoodleCJ.Modles
{
    public class FeedBackReprositity : IFeedBackReprositity
    {
        private readonly AppDbContext _context;
        public FeedBackReprositity(AppDbContext context)
        {
            _context = context;
        }



        public IEnumerable<FeedBack> GetFeedBacks()
        {
            return _context.FeedBacks;
        }

        public FeedBack GetFeedById(int id)
        {
            return _context.FeedBacks.FirstOrDefault(n => n.Id == id);
        }

        public void AddFeedBack(FeedBack feedBack)
        {
            _context.FeedBacks.Add(feedBack);
            _context.SaveChanges();
        }
    }
}
