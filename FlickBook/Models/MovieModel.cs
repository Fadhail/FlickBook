using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickBook.Models
{
    public class Movie
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public string ReleaseDate { get; set; }
        public string Language { get; set; }
        public string Genre { get; set; }
        public string Backdrop { get; set; }
    }
}
