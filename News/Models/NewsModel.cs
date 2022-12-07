using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class NewsModel
    {
        public string title { get; set; }
        public DateTime updated { get; set; }
        public  List<Article> articles { get; set; }
    }
}
