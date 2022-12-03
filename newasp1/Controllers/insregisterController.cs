using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace newasp1.Controllers
{
    public class insregisterController : Controller
    {
        // GET: insregister
        public ActionResult Index()
        {
            return View();
        }
        //public ActionResult AddInstructor(InstructorAccount instructorAccount)
        //{
        //    string message = string.Empty;
        //    using (Model1 db = new Model1())
        //    {

        //        if (db.Users.Any(x => x.UserName == user.UserName))
        //        {
        //            //ViewBag.DuplicateMessage("Username Already Exist");
        //            message = "Username Already Exist";
        //            ViewBag.DuplicateMessage = message;
        //            return View("AddUser", user);
        //        }
        //        else
        //        {
        //            db.Users.Add(user);
        //            db.SaveChanges();
        //        }
        //        ModelState.Clear();
        //        // ViewBag.SuccessMessage("saved sucessfully");\
        //        message = "saved sucessfully";
        //        ViewBag.Message = message;
        //        return View("AddUser", new User());
        //    }
        //}
    }
}