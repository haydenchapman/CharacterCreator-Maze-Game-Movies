using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.MovieLib
{   
    /// <summary> Manages the movies in a database. </summary>
    public class MovieDatabase
    {
        public Movie Add ( Movie movie )
        {
            movie.Id = ++_id;
            _movies.Add (movie);

            return movie;

            //Add to array
            //for (var index = 0; index < _movies.Count; ++index)
            //{
            //    if (_movies[index] == null)
            //    {
            //        _movies[index] = movie;
            //        return;
            //    };
            //};
        }

        public void Remove ( int id )
        {
            var movie = FindMovie (id);
            if (movie !=null) 
            _movies.Remove (movie);

            
            //Remove from array
            //for (var index = 0; index < _movies.Count; ++index)
            //{
            //    //This won't work
            //    if (_movies[index] == movie)
            //    {
            //        _movies[index] = null;
            //        return;
            //    };
            //};
        }

        public Movie[] GetAll ()
        {
            //Filter out empty movies
            //var count = 0;
            //foreach (var movie in _movies)
            //    if (movie != null)
            //        ++count;

            var index = 0;
            var movies = new Movie[_movies.Count];
            foreach (var movie in _movies)
                if (movie != null)
                    movies[index++] = movie;

            return movies;
        }

        private Movie FindMovie (int id)
        {
            foreach (var movie in _movies)
                if (movie.Id == id)
                    return movie;

            return null;
        }

        public void Update(int id, Movie newMovie )
        {
            var existing = FindMovie (id);
            if (existing == null)
                return;//TODO error
                       //TODO: Change to update

            //update existing movie
            existing.Description = newMovie.Description;
            existing.HasSeen = newMovie.HasSeen;
            existing.Rating = newMovie.Rating;
            existing.ReleaseYear = newMovie.ReleaseYear;
            existing.RunLength = newMovie.ReleaseYear;
            existing.Title = newMovie.Title;


           // _movie.Remove (movie);
            //RemoveMovie(form.Movie);
           // _movie.Add (form.Movie);
        }

        public Movie get (int id)
        {
            return FindMovie (id);
        }

        //private Movie[] _movies = new Movie[100];
        private List<Movie> _movies = new List<Movie> ();

        //
        private int _id = 0;
    }

}
