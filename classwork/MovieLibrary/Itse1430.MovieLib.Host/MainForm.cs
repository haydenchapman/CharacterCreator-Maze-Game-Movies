using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using Itse._1430.MovieLib.SqlServer;
using Itse1430.MovieLib.IO;

namespace Itse1430.MovieLib.Host
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent ();

            //Itse1430.MovieLib.Movie
            //Movie movie = new Movie ();
            //movie.Title = "Jaws";
            //movie.Description = movie.Title;
        }

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad (e);
            var connString = ConfigurationManager.ConnectionStrings["MovieDatabase"];
            //_movies = new FileMovieDatabase (@"movies.csv");
            _movies = new SqlMovieDatabase (connString.ConnectionString);
            //var count = _movies.GetAll ().Count ();
            //if (count == 0)
            //    //MovieDatabaseExtensions.Seed (_movies);
            //    _movies.Seed ();

            UpdateUI ();
        }

        //Called when Movie\Add selected
        private void OnMovieAdd ( object sender, EventArgs e )
        {
            var form = new MovieForm ();

            //Modeless - does not block main window
            //form.Show();

            //Show the new movie form modally
            if (form.ShowDialog (this) == DialogResult.OK)
            {
                try
                {
                    _movies.Add (form.Movie);
                    UpdateUI ();
                } catch (ArgumentException ex)
                {
                    //Recovery
                    MessageBox.Show (ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } catch (ValidationException ex)
                {
                    //Recovery
                    MessageBox.Show (ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } catch //(Exception ex)
                {
                    //Recovery
                    MessageBox.Show ("Save Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //throw;
                };
            };
        }

        private Movie GetSelectedMovie ()
        {
            var item = _lstMovies.SelectedItem;
            //if (item == null)
            //    return null;

            //Movie or null
            return item as Movie;

            //var firstMovie = _lstMovies.SelectedItems
            //                          .OfType<Movie> ()
            //                          .FirstOrDefault ();


            //old approach1
            //var tempVar = item as Movie;
            //if (tempVar) != null
            //   {
            //   };
            //other approaches 2
            //C style cast 
            //(Movie)item;
            //item is Movie;
            //{
            //then do something with movie
            //}
            //pattern matching
            //if (item is Movie movie)
            //{
            //};
        }

        private void OnMovieEdit ( object sender, EventArgs e )
        {
            //Get selected movie
            var movie = GetSelectedMovie ();
            if (movie == null)
                return;

            var form = new MovieForm ();
            form.Movie = movie;

            if (form.ShowDialog (this) == DialogResult.OK)
            {
                _movies.Update (movie.Id, form.Movie);
                UpdateUI ();
            };
        }

        private void OnMovieDelete ( object sender, EventArgs e )
        {
            //Demo
            var menuItem = sender as Button;
            //var text = menuItem.Text;

            //handle null
            var text = "";
            if (menuItem != null)
                text = menuItem.Text;
            else
                text = "";

            //as expression
            var text2 = (menuItem != null) ? menuItem.Text : "";

            //null coalescing menuItem ?? "";
            //null conditional
            var text3 = menuItem?.Text ?? "";

            var movie = GetSelectedMovie ();
            if (movie == null)
                return;

            //Confirmation
            var msg = $"Are you sure you want to delete {movie.Title}?";
            var result = MessageBox.Show (msg, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            //Delete it
            _movies.Remove (movie.Id);
            UpdateUI ();
        }

        private void OnFileExit ( object sender, EventArgs e )
        {
            Close ();
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var form = new AboutForm ();
            form.ShowDialog (this);
        }

        //private string OrderByTitle(Movie movie )
        //{
        //    return movie.Title;
        //}
        //private int OrderByReleaseYear(Movie movie )
        //{
        //    return movie.ReleaseYear;
        //}
        private void UpdateUI ()
        {
            var movies = from m in _movies.GetAll ()
                         orderby m.Title, m.ReleaseYear
                         select m;

            //var movies = _movies.GetAll ()
            //                    //.OrderBy (OrderByTitle)
            //                    .OrderBy(m => m.Title)
            //                    //.ThenBy (OrderByReleaseYear)
            //                    .ThenBy (m => m.ReleaseYear);

            PlayWithEnumerable (movies);

            //Programmatic approach
            //_lstMovies.Items.Clear ();
            //_lstMovies.Items.AddRange (movies);

            _lstMovies.DataSource = movies.ToArray();
        }

        private void PlayWithEnumerable ( IEnumerable<Movie> movies )
        {
            Movie firstOne = movies.FirstOrDefault ();
            Movie lastOne = movies.LastOrDefault ();
            //Movie onlyOne = movies.SingleOrDefault();

            //var coolMovies = movies.Where (m => m.ReleaseYear > 1979 && m.ReleaseYear < 2000);
            int id = 1;
            var otherMovies = movies.Where (m => m.Id > ++id);
        }

        //private Movie[] _movies = new Movie[100];
        //private List<Movie> _movies = new List<Movie>();

        private IMovieDatabase _movies;

        private void MainForm_Load ( object sender, EventArgs e )
        {

        }
    }
}
