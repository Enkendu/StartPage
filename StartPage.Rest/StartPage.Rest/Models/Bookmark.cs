using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartPage.Rest.Models
{
    public class Bookmark
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }
        public string Page { get; set; }
    }
}
