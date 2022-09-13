using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopLibLogic
{
    internal class Article
    {
        public int ArticleID { get; set; }
        public string ArticleName { get; set; }       
        public double ArticlePrice { get; set; }
        public string ArticleDescription { get; set; }
        public int ArticleCount { get; set; }
    }
}
