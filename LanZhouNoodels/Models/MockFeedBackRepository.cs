using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanZhouNoodels.Models
{
    public class MockFeedBackRepository : IFeedBackRepository
    {
        private List<FeedBack> _feedBacks;
        public MockFeedBackRepository() {
            if (_feedBacks == null) {
                Initialization();
            }
        }
        private void Initialization() {
            _feedBacks = new List<FeedBack> {
                new FeedBack { Id=1 , Name="反馈1",Email="feedback@163.com",CreateDateUtc=DateTime.Now,Message="信息1"},
                new FeedBack { Id=2 , Name="反馈1",Email="feedback@163.com",CreateDateUtc=DateTime.Now,Message="信息1"},
                new FeedBack { Id=3 , Name="反馈1",Email="feedback@163.com",CreateDateUtc=DateTime.Now,Message="信息1"},
                new FeedBack { Id=4 , Name="反馈1",Email="feedback@163.com",CreateDateUtc=DateTime.Now,Message="信息1"},
                new FeedBack { Id=5 , Name="反馈1",Email="feedback@163.com",CreateDateUtc=DateTime.Now,Message="信息1"},
                new FeedBack { Id=6 , Name="反馈1",Email="feedback@163.com",CreateDateUtc=DateTime.Now,Message="信息1"},
            };
        }
        public IEnumerable<FeedBack> GetFeedBacks()
        {
            return _feedBacks;
        }
    }
}
