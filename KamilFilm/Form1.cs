using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KamilFilm
{
    public partial class KamilFilm : Form
    {
        public KamilFilm()
        {
            InitializeComponent();
        }

        private void KamilFilm_Load(object sender, EventArgs e)
        {
            var filmy = new[]
            {
            new {FilmID=1, Title="Pulp Fiction", Year=1994,Director="Tarantino" },
            new {FilmID=2, Title="Przelecz ocalonych", Year=2016,Director="Gibson" },
            new {FilmID=3, Title="Kill Bill", Year=2003,Director= "Tarantino"},
            new { FilmID = 4, Title = "Ojciec Chrzestny", Year =1972,Director= "Coppola"},
            new { FilmID = 5, Title = "Skazani na Shawshank", Year= 1994, Director="Darabont"},
            new { FilmID = 6, Title = "Forrest Gump", Year= 1994, Director="Zemeckis"},
            new { FilmID = 7, Title = "Gran Torino", Year=2008, Director="Eastwood"},
            new { FilmID = 8, Title = "Cinema Paradiso", Year=1988, Director="Tornatore"}
            };


            var movieTitles = from f in filmy
                              select f.Title;
            tytuly_lbl.Text += "\n";
            foreach (string tytul in movieTitles)
            {
                tytuly_lbl.Text += tytul + "\n";
            }
        }
    }
}
