using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanZhouNoodleCJ.Modles
{
    public class NoodleReprositity : INoodleReprositity
    {
        private readonly AppDbContext _context;
        public NoodleReprositity(AppDbContext context) {
            _context = context;
        }
        public IEnumerable<Noodle> GetAllNoodles()
        {
            return _context.Noodles;
        }

        public Noodle GetNoodleById(int id)
        {
            return _context.Noodles.FirstOrDefault(n => n.Id == id);
        }
    }
}
