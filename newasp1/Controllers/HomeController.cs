using newasp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace newasp1.Controllers
{
    public class HomeController : Controller
    {
        private Model1 db = new Model1();
        CommentRepositry repo = new CommentRepositry();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult CommentPartial()
        {
            //object repo = null

            var comments = repo.GetAll();
            return PartialView("_CommentPartial", comments);
        }

        public JsonResult addNewComment(Comment comment)
        {
            try
            {
                var model = repo.AddComment(comment);

                return Json(new { error = false, result = model }, JsonRequestBehavior.AllowGet);

            }
            catch (Exception)
            {
                //Handle Error here..
            }

            return Json(new { error = true }, JsonRequestBehavior.AllowGet);
        }


    }
}