using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanZhouNoodels.Models
{
    public interface INoodleRepository
    {
        IEnumerable<Noodle> GetAllNoodles();
        Noodle GetNoodleById(int id);
    }
}
