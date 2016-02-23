using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using asp_lesson_5_12.Models;

namespace asp_lesson_5_12.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View(new Book());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();
            return View("ResultOfAdding", book);
        }

         

    }
}