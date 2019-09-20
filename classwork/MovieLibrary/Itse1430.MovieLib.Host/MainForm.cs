using System;
using System.Windows.Forms;


namespace Itse1430.MovieLib.Host
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent ();

            var movie = new Movie ();
            movie = new Movie ();
            movie.title = "Jaws";
            //movie.description
        }

        private void AddToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            var form = new MovieForm ();
            //modeless - does not block main window
            //form.Show();

            //Show the new movie form modally
            if (form.showDialog(this) == DialogResult.OK)

            form.ShowDialog ();
            //true save it
            _movie = form.Movie;
        }

        private Movie _movie;
    }
}
