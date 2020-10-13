using LanZhouNoodleCJ.Modles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanZhouNoodleCJ.Controllers
{
    public class FeedBackController : Controller
    {
        private IFeedBackReprositity _feedBackReprositity;
        public FeedBackController(IFeedBackReprositity feedBackReprositity) {
            _feedBackReprositity = feedBackReprositity;
        }
        [Authorize]
        public IActionResult Index() {
            return View();
        }

        [HttpPost]
        public IActionResult Index(FeedBack feedBack) {
            if (ModelState.IsValid)
            {
                _feedBackReprositity.AddFeedBack(feedBack);
                return RedirectToAction("FeedBackComplete");
            }
            else
            {
                return View();
            }
        }

        public IActionResult FeedBackComplete() {
            return View();
        }
    }
}
