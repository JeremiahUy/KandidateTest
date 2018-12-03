using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kandidattest.Models;


namespace Kandidattest.Controllers
{
    public class SignupController : Controller
    {
        //
        // GET: /Signup/
        public ActionResult Index()
        {          
            return View();
        }

        [HttpPost]
        public ActionResult Index(VMsignup bruker)
        {
            if (ModelState.IsValid)
            {
                

                return RedirectToAction("statiskkAlder", "Statistikk");
            }
            return View();
        }

    }
}