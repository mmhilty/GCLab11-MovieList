using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab11_MovieList
{
    class Movie
    {
        public Movie(string title, string genre)
        {
            this.title = title;
            this.genre = genre;
        }
        private string title;
        private string genre;

        public string Title
        {
            set
            {
                title = value;
            }
            get
            {
                return title;
            }
        }
        public string Genre { set; get; }

    }
}
