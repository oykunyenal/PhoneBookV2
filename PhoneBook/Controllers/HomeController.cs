using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Models;

namespace PhoneBook.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult getFormVal(Contact contactInfo)
        {
            String number = contactInfo.Number;
            ViewBag.ad = contactInfo.Name;
            return View();
        }

    }
}
