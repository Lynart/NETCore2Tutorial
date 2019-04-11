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
        private DutchContext _ctx;

        public AppController(IMailService mailService, DutchContext ctx)
        {
            _mailService = mailService;
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            var results = _ctx.Products.ToList();
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
    }
}
