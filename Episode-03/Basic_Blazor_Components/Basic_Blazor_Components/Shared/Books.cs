using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Blazor_Components.Shared
{
    public class Books
    {
        public string BookCode { get; set; }

        public string BookName { get; set; }

        public string AuthorName { get; set; }

        public string Category { get; set; }

        public string AboutInfo { get; set; }

        public string CoverImageUrl { get; set; }

        public double Ratings { get; set; }
    }
}
