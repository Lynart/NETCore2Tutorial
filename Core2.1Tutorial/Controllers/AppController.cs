using Core2._1Tutorial.Services;
using Core2._1Tutorial.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core2._1Tutorial.Controllers
{
    public class AppController : Controller
    {
        private IMailService _mailService;

        public AppController(IMailService mailService)
        {
            _mailService = mailService;
        }

        public IActionResult Index()
        {
            return View();
        }

         
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                //Send email
            }
            else
            {
                //show errors
            }
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";

            return View();
        }
    }
}
