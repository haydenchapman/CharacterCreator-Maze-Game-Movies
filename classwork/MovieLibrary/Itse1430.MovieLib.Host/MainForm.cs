using System;
using System.Windows.Forms;


namespace Itse1430.MovieLib.Host
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent ();

            //var movie = new Movie ();
           // movie = new Movie ();
           // movie.Title = "Jaws";
            //movie.description
           // movie.description = 
        }

        private void OnMovieAdd ( object sender, EventArgs e )
        {
            var form = new MovieForm ();

            //modeless - does not block main window
            //form.Show();

            //Show the new movie form modally
            if (form.ShowDialog(this) == DialogResult.OK)

            form.ShowDialog ();
            //true save it
            _movie = form.Movie;
        }

        private Movie _movie;

        private void OnMovieEdit ( object sender, EventArgs e )
        {

        }

        private void OnMovieDelete ( object sender, EventArgs e )
        {

        }

        private void OnFileExit ( object sender, EventArgs e )
        {

        }
    }
}
