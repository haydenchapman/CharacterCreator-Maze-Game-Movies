using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.MovieLib
{   
    /// <summary> Manages the movies in a database. </summary>
    public class MovieDatabase
    {
        //constructor startup
        public MovieDatabase ()
        {
            //collections initializer
            _movies = new List<Movie> {
                new Movie() {Id = ++_id, Title = "Jaws", ReleaseYear = 1979, Rating = "PG", },
                new Movie() {Id = ++_id, Title = "Star Wars", ReleaseYear = 1977, Rating = "PG", },
                new Movie() {Id = ++_id, Title = "Demon Slayer", ReleaseYear = 2019, Rating = "PG", },
                new Movie() {Id = ++_id, Title = "Star Trek", ReleaseYear = 2016, Rating = "PG-13", },
            };

           // var movie = new Movie () {
           //     Id = ++_id,
           //     Title = "Jaws",
           //     ReleaseYear = 1979,
           //     Rating = "PG",
           // };
           // Add (movie);

           // _movies.Add (movie);
            //movie = new Movie () {
            //    Id = ++_id,
            //    Title = "Star Wars",
            //    ReleaseYear = 1977,
            //    Rating = "PG",
            //};
            ////Add (movie);
            //_movies.Add (movie);

            //movie = new Movie () {
            //    Id = ++_id,
            //    Title = "Demon Slayer",
            //    ReleaseYear = 2019,
            //    Rating = "PG",
            //};
            ////Add (movie);
            //_movies.Add (movie);

            //movie = new Movie () {
            //    Id = ++_id,
            //    Title = "Star Trek",
            //    ReleaseYear = 2016,
            //    Rating = "PG-13",
            //};
            ////Add (movie);
            //_movies.Add (movie);
        }
        public Movie Add ( Movie movie )
        {
            //TODO: Validation
            if (movie == null)
                return null;
            //if (!String.IsNullOrEmpty(movie.Validate())) 
            var context = new ValidationContext (movie);
            var results = movie.Validate (context);
            if (results.Count () > 0)
                return null;

            //name must be unique
            var existing = FindMovie (movie.Title);
            if (existing != null)
                return null;

            //add movie if validation works
            movie.Id = ++_id;

            var newMovie = Clone (new Movie (), movie);
            _movies.Add (newMovie);

            return movie;

            // Old Array Code
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
                    movies[index++] = Clone(new Movie(), movie);

            return movies;
        }

        private Movie Clone( Movie target, Movie source )
        {
            target.Id = source.Id;
            target.Description = source.Description;
            target.HasSeen = source.HasSeen;
            target.Rating = source.Rating;
            target.ReleaseYear = source.ReleaseYear;
            target.RunLength = source.RunLength;
            target.Title = source.Title;

            return target;
        }

        private Movie FindMovie (int id)
        {
            foreach (var movie in _movies)
                if (movie.Id == id)
                    return movie;

            return null;
        }

        private Movie FindMovie ( string name )
        {
            foreach (var movie in _movies)
                if (String.Compare(movie.Title, name, true) == 0)
                    return movie;

            return null;
        }

        public void Update(int id, Movie newMovie )
        {
            //validate
            if (id <= 0)
                return;
            if (newMovie == null)
                return;
            //if (!String.IsNullOrEmpty (newMovie.Validate ()))
            var context = new ValidationContext (newMovie);
            var results = newMovie.Validate (context);
            if (results.Count () > 0)
                return;

            //name must be unique
            var existing = FindMovie (newMovie.Title);
            if (existing != null && existing.Id != id)
                return;

            existing = FindMovie (id);
            if (existing == null)
                return;//TODO error
                       //TODO: Change to update

            //update existing movie
            newMovie.Id = id;
            Clone (existing, newMovie);

           // _movie.Remove (movie);
            //RemoveMovie(form.Movie);
           // _movie.Add (form.Movie);
        }

        public Movie get (int id)
        {
            //validate
            if (id <= 0)
                return null;

            var movie = FindMovie (id);
            return movie != null ? Clone (new Movie (), movie) : null;
        }

        //private Movie[] _movies = new Movie[100];
        private List<Movie> _movies = new List<Movie> ();

        //
        private int _id = 0;
    }

}
