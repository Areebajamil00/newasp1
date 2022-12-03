//using newasp1.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace newasp1.Controllers
//{
//    public class LoginController : Controller
//    {
//        // GET: Login
//        public ActionResult Index()
//        {
//            return View();
//        }
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Index(User obj)
//        {
//            if (ModelState.IsValid)
//            {
//                string message = string.Empty;
//                using (Model1 db = new Model1())
//                {
//                    var obj1 = db.Users.Where(a => a.Email.Equals(obj.Email) && a.Password.Equals(obj.Password)).FirstOrDefault();
//                    if (obj1 != null)
//                    {
//                        Session["Email"] = obj1.Email.ToString();
//                        Session["Password"] = obj1.Password.ToString();
//                        // Session["bit"]=

//                        message = "Log in successfully";
//                        ViewBag.Meassage = message;
//                        return RedirectToAction("Index", "Post");
//                    }
//                    else
//                    {
//                        // ModelState.AddModelError(" ", "Not a valid user ");
                        
//                        message = "This is not a valid user create account fisrt";
//                        ViewBag.DuplicateMeassage = message;
//                        return RedirectToAction("Login", "Index");

//                    }
//                }

//            }

//            return View();
//        }

//        private ActionResult RedirectToAction()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}