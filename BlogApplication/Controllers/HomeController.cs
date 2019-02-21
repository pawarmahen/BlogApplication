using Blog.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ArticlePage objAct = new ArticlePage()
            {
                Author = "",
                Body = "",
                Comments = new List<ArticleComments>(),
                CreatedBy = "",
                CreatedOn = DateTime.Now,
                Description = "",
                Id = 1,
                Title = "Articles",
                UpdatedBy = "",
                UpdatedOn = DateTime.Now

            };
            return View(objAct);
        }

        public ActionResult GetArticles()
        {
            return View();
        }
    }
}