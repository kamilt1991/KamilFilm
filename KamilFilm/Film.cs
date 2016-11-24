using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KamilFilm
{
    class Film
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }

        public Film(string title, int year, string director)
        {
            this.Title = title;
            this.Year = year;
            this.Director = director;
        }
    }
}
