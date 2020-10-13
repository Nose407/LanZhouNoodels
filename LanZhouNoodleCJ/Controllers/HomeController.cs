using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanZhouNoodleCJ.Modles;
using LanZhouNoodleCJ.ViewModles;

namespace LanZhouNoodleCJ.Controllers
{
    public class HomeController : Controller
    {
        private IFeedBackReprositity _feedBackReprositity;
        private INoodleReprositity _noodleReprositity;

        public HomeController(IFeedBackReprositity feedBackReprositity, INoodleReprositity noodleReprositity) {
            _feedBackReprositity = feedBackReprositity;
            _noodleReprositity = noodleReprositity;
        }

        public IActionResult Index()
        {
            var content = new HomeViewModle() {
                Noodles = _noodleReprositity.GetAllNoodles().ToList(),
                FeedBacks = _feedBackReprositity.GetFeedBacks().ToList()
            };
            return View(content);
        }
    }
}
