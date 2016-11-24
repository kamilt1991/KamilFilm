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
            List<Film> ListaFilmow = new List<Film>();
            ListaFilmow.Add(new Film("Pulp Fiction", 1994, "Tarantino"));
            ListaFilmow.Add(new Film("Przelecz ocalonych", 2016, "Gibson"));
            ListaFilmow.Add(new Film("Kill Bill", 2003, "Tarantino"));
            ListaFilmow.Add(new Film("Ojciec Chrzestny", 1972, "Coppola"));
            ListaFilmow.Add(new Film("Skazani na Shawshank", 1994, "Darabont"));
            ListaFilmow.Add(new Film("Forrest Gump", 1994, "Zemeckis"));
            ListaFilmow.Add(new Film("Gran Torino", 2008, "Eastwood"));
            ListaFilmow.Add(new Film("Cinema Paradiso", 1988, "Tornatore"));
            //ListaFilmow.Add(new Film("",, ""));
            //ListaFilmow.RemoveAll(x=>x.Title=="Pulp Fiction");
            foreach (Film film in ListaFilmow)
            {
                ListViewItem items = new ListViewItem(film.Title);
                items.SubItems.Add(film.Year.ToString());
                items.SubItems.Add(film.Director);
                lista_filmow_lv.Items.Add(items);
            }
        }
    }
}
