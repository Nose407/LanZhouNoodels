using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LanZhouNoodels.Controllers
{
    [Route("admin/[controller]/[action]")]
    public class NoodleController : Controller
    {
        public IList<String> Index()
        {
            return new List<string> { "haohaohao","haohao","hao"};
        }
    }
}
