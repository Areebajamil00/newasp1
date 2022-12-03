using newasp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace newasp1.Controllers
{
    public class InstructoroLoginController : Controller
    {
        // GET: InstructoroLogin
        public ActionResult InsLogin()
        {
            using (Model1 db = new Model1())
            {
                return View(db.InstructorLogins.ToList());
            }
        }
        [HttpPost]
        public ActionResult InsLogin(InstructorLogins obj)
        {
            string msg = " ";
            if (ModelState.IsValid)
            {
                using (Model1 db = new Model1())
                {
                    var obj1 = db.Users.Where(a => a.UserName.Equals(obj.Email) && a.Password.Equals(obj.Password)).FirstOrDefault();
                    if (obj1 != null)
                    {
                        Session["UserId"] = obj1.id.ToString();
                        Session["Email"] = obj1.Email.ToString();
                        // Session["bit"]=
                        msg = "successfully log in";
                        ViewBag.Message = msg;
                        // return RedirectToAction("Index", "Post");
                    }
                    else
                    {

                        ModelState.AddModelError(" ", "The username password invalid ");
                        msg = "Not exist";
                        ViewBag.DuplicateMessage = msg;
                        //return RedirectToAction("InsLogin");
                    }
                }

            }

            return View();
        }
    }
}