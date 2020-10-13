using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanZhouNoodels.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace LanZhouNoodels.Controllers
{
    [Authorize]
    public class FeedBackController : Controller
    {
        IFeedBackRepository _feedBackRepository;
        public FeedBackController(IFeedBackRepository feedBackRepository)
        {
            _feedBackRepository = feedBackRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(FeedBack feedBack)
        {
            // Tag helper
            if (ModelState.IsValid)
            {
                feedBack.CreateDateUtc = DateTime.Now;
                _feedBackRepository.AddFeedBack(feedBack);
                return RedirectToAction("FoodBackComplete");
            }
            else
            {
                return View();
            }

        }

        public IActionResult FoodBackComplete()
        {
            return View();
        }
    }
}
