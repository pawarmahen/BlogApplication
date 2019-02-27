using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Blog.DataAccess.Models;

namespace BlogApplication.ViewModels
{
    public class ListOfArticlesViewModel
    {
        public ListOfArticlesViewModel() { }

        public ICollection<ArticlePage> ArticlPageList { get; set;}

        public ArticlePage CurrentArticle { get; set; }
    }
}