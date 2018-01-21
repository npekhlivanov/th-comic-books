using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "SpiderMan",
                IssueNumber = 99,
                DescriptionHtml = "<p>Final issue!</p>",
                Artists = new Artist[]
                {
                    new Artist() { Role = "Script", Name = "John" },
                    new Artist() { Role = "Pencil", Name = "Jimmy" }
                }
            };

            return View(comicBook);
            //return Content("Hello");
            //return Redirect("/");
        }
    }
}