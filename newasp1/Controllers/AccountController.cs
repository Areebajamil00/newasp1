using newasp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace newasp1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [Authorize]
        public ActionResult Index()
        {
            using (Model1 db = new Model1())
            {
                return View(db.Users.ToList());
            }
               
        }
        public ActionResult Loginn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Loginn(User user)
        {
            using (Model1 db = new Model1())
            {
                var usr = db.Users.Where(a => a.Email.Equals(user.Email) && a.Password.Equals(user.Password)).FirstOrDefault();
                if (usr!=null)
                {
                    String message = "";
                    FormsAuthentication.GetAuthCookie(user.UserName,false);
                    Session["id"] = usr.id.ToString();
                    Session["Email"] = usr.Email.ToString();
                    message = "Log in successfully";
                    ViewBag.Meassage = message;
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("","User name and password is  wrong");

                }
            }
                return View();
        }
        public ActionResult LoggedIn()
        {
            if (Session["id"] != null)
            {
                return RedirectToAction("Index","Post");
            }
            else
            {
                String message = "";
                message = "Invalid user";
                ViewBag.DuplicateMessage = message;
                return RedirectToAction("Loginn");
            }
        }
      

       
    }
}