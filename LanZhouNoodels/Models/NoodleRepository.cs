using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanZhouNoodels.Models
{
    public class NoodleRepository : INoodleRepository
    {
        private readonly AppDBContext _context;
        public NoodleRepository(AppDBContext context) {
            _context = context;
        }
        public IEnumerable<Noodle> GetAllNoodles()
        {
            return _context.Noodles;
        }

        public Noodle GetNoodleById(int id)
        {
            return _context.Noodles.FirstOrDefault(n=>n.Id==id);
        }
    }
}
