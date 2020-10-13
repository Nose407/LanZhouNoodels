using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanZhouNoodels.Models;
using LanZhouNoodels.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanZhouNoodels.Controllers
{
    //[Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private INoodleRepository _noodleRepository;
        private IFeedBackRepository _feedBackRepository;
        public HomeController(INoodleRepository noodleRepository,IFeedBackRepository feedBackRepository)
        {
            _noodleRepository = noodleRepository;
            _feedBackRepository = feedBackRepository;
        }
        public IActionResult Index()
        {
            //var noodles = _noodleRepository.GetAllNoodles();
            var viewModel = new HomeViewModel()
            {
                Noodles = _noodleRepository.GetAllNoodles().ToList(),
                FeedBacks = _feedBackRepository.GetFeedBacks().ToList()
            };
            return View(viewModel);
        }
        //[Route("aboutus")]HomeController1.cs
        public String About() {
            return "this is About";
        }

        public IActionResult Detail(int id)
        {
            return View(_noodleRepository.GetNoodleById(id));
        }
    }
}
