using newasp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace newasp1.Controllers
{
    public class LOGINIController : Controller
    {
        // GET: LOGINI
        [AllowAnonymous]
        public ActionResult LOGINS()
        {
            return View();
        }

   
     
        [HttpPost]
        [AllowAnonymous]
        public ActionResult LOGINS(InstructorLogin ins)
        {
            Model1 db = new Model1();
            var userId = db.InstructorAccounts.Where(a => a.Email.Equals(ins.Email) && a.Password.Equals(ins.Password)).FirstOrDefault();

            string message = string.Empty;
            if (userId != null)
            {
              
                FormsAuthentication.GetAuthCookie(ins.Email, false);
                Session["id"] = userId.id.ToString();
                Session["Email"] = userId.Email.ToString();
                message = "Log in successfully";
                ViewBag.Meassage = message;
                return RedirectToAction("Post","Post");
            }
            else
            {
                ModelState.AddModelError("", "User name and password is  wrong");

            }

        
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}