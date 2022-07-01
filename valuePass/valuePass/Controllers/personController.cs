using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using valuePass.Models;

namespace valuePass.Controllers
{
    public class personController : Controller
    {
      
        
        // GET: person
        public ActionResult Information()
        {
            Person a1 = new Person()
            {
                Name = "Shagor Kanti Rakshit",
                Age = "21",
                Semester = "10th"
            };
            return View(a1); ;
        }
        
    }
}