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
            var from = new MovieForm ();

            from.ShowDialog ();
        }
    }
}
