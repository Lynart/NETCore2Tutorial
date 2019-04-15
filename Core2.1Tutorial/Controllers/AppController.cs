using Core2._1Tutorial.Data;
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

        private IDutchRepository _repo;

        public AppController(IMailService mailService, IDutchRepository repo)
        {
            _mailService = mailService;
            _repo = repo;
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
                ViewBag.UserMessage = "Mail Sent";
                _mailService.SendMessage(model.Email, model.Subject, model.Message);
                ModelState.Clear();

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

        public IActionResult Shop()
        {
            var results = _repo.GetAllProducts();

            return View(results);
        }
    }
}
