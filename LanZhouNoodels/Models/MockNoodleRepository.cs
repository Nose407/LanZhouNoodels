using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanZhouNoodels.Models
{
    public class MockNoodleRepository : INoodleRepository
    {
        private List<Noodle> _noodles;
        public MockNoodleRepository()
        {
            if (_noodles == null)
            {
                InitializeNoodle();
            }
        }
        private void InitializeNoodle()
        {
            _noodles = new List<Noodle> {
                new Noodle { Id=1,Name="你好1",StrotDescription="你好1",LongDescription="你好1",Price=12,ImgUrl="images/001.png"},
                new Noodle { Id=1,Name="你好1",StrotDescription="你好1",LongDescription="你好1",Price=12,ImgUrl="images/001.png"},
                new Noodle { Id=1,Name="你好1",StrotDescription="你好1",LongDescription="你好1",Price=12,ImgUrl="images/001.png"},
                new Noodle { Id=1,Name="你好1",StrotDescription="你好1",LongDescription="你好1",Price=12,ImgUrl="images/001.png"},
                new Noodle { Id=1,Name="你好1",StrotDescription="你好1",LongDescription="你好1",Price=12,ImgUrl="images/001.png"},
                new Noodle { Id=1,Name="你好1",StrotDescription="你好1",LongDescription="你好1",Price=12,ImgUrl="images/001.png"}
            };
        }
        public IEnumerable<Noodle> GetAllNoodles()
        {
            return _noodles;
        }

        public Noodle GetNoodleById(int id)
        {
            return _noodles.FirstOrDefault(n => n.Id == id);
        }
    }
}
