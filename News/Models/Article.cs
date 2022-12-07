using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Article
    {
        public string title { get; set; }
        public DateTime date { get; set; }
        public string content { get; set; }
        public string linkToContent { get; set; }

    }
}
