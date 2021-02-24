using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SRMMVC2_.Models.Classes;
using System.Web.Security;

namespace SRMMVC2_.Controllers
{
    public class AuthController : Controller
    {
        Context cn = new Context();
       
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
      
        [HttpGet]
        public ActionResult Auth()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Auth(Admin a)
        {
            var admin = cn.Admins.Any(x => x.Password == a.Password && x.Username == a.Username);
            if(admin)
            {
                FormsAuthentication.SetAuthCookie(a.Username, false);
                return RedirectToAction("Index", "Home");
            }


            return RedirectToAction("Auth","Auth");
        }




    }
}