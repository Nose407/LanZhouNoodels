using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanZhouNoodleCJ.Modles
{
    public interface INoodleReprositity
    {
        IEnumerable<Noodle> GetAllNoodles();

        Noodle GetNoodleById(int id);
    }
}
