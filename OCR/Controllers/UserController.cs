using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OCR.Models;

namespace OCR.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Create([FromBody] User u )
        {
            using(var context = new OCRContext())
            {
                User test = new User();
                test.Emri = u.Emri;

                context.User.Add(test);
                context.SaveChanges();
            }
            return View();
        }
    }
}