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
        private static ArticlePage _page = new ArticlePage();
        
        // GET: Home
        public ActionResult Index()
        {
            _page = new ArticlePage()
            {
                Author = "Chacko Daniel",
                Body = "<div class=\"Normal\">Azure Service Fabric is a distributed computing platform that makes it easy to build, deploy, and operate always-on, mission-critical microservice applications (containerized and non-containerized). Developers focus on building microservices, and the service fabric platform solves the hard problems like lifecycle management, orchestration, availability and scalability of the applications.</br>The platform also has a built -in,highly available,low - latency in memory state store with persistence.The developers can use this store via programmatic data structures(Dictionary and Queues) or as attached volume disk to build stateful microservices. </ br >Azure Service Fabric is open source and runs on both Windows and Linux,and you can use it either on - premises or in the cloud—it’s a great hybrid solution that can support demanding “cloud native” applications.</ br >Azure Service Fabric has three public offerings: Service Fabric Azure Cluster service, Service Fabric Standalone, and Azure Service Fabric Mesh service.</div>",

                Comments = new List<ArticleComments>() {
                    new ArticleComments
                    {
                        Comment="dsjfkdsjkbf"
                    },
                     new ArticleComments
                    {
                        Comment="dsjfkdsjkbf"
                    },
                      new ArticleComments
                    {
                        Comment="dsjfkdsjkbf"
                    }
                }
                    ,
                CreatedBy = "Chacko Daniel",
                CreatedOn = DateTime.Now,
                Description = "ghjhgjhgj",
                Id = 1,
                Title = "Exploring Azure Service Fabric Mesh: A Platform for Building Mission Critical Microservices",
                UpdatedBy = "Chacko Daniel",
                UpdatedOn = DateTime.Now,
                Image = new Uri(@"https://res.infoq.com/articles/azure-service-fabric-mesh/en/resources/1azure-service-fabric-mesh-1543001783194.jpg")

            };
            return View(_page);
        }
        //public string generateID()s
        //{
        //    return Guid.NewGuid().ToString("N001");
        //}

        [HttpPost]
        public string PartialViewMethod(ArticleComments comment)
        {
            //_page.Comments.Add(comment);
            return "Success";
        }
        public ActionResult GetArticles()
        {
            return View();
        }

    }
}