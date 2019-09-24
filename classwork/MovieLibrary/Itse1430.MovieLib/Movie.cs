using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.MovieLib
{
    /// <summary> Represents movie data.</summary>
    public class Movie
    {
        /// <summary>get or sets title of the movie</summary>
        public string Title
        {
            //null coalescing
            //
            get { return _title ?? ""; }
            set { _title = value; }
        }

        /// <summary>gets or sets description</summary>
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }

        /// <summary> gets or sets rating</summary>
        public string Rating
        {
            get { return _rating ?? ""; }
            set { _rating = value; }
        }

        /// <summary>gets or sets release year</summary>
        public int ReleaseYear { get; set; } = 1900; //Auto property
        
        //Full Property
        //public int ReleaseYear
        // {
        //   get { return _releaseYear; }
        //   set { _releaseYear = value; }
        // }

        /// <summary>gets or sets run length</summary>
        public int RunLength { get; set; }
       // { 
       //     get { return _runLength; }
       //     set { _runLength = value; }
       // }

        /// <summary>gets or sets has seen</summary>
        public bool HasSeen { get; set; }
        // {
        //    get { return _hasSeen; }
        //    set { _hasSeen = value; }
        // }

        //value is 1939, read only, public
        //public int ReleaseYearForColor { get; } = 1939;

        //const field example
        public const int ReleaseYearForColor = 1939;
        //public readonly int ReleaseYearForColor = 1939;
        //private readonly int _releaseYearForColor = 1939;

        /// <summary>Determines if movie is black or white.</summary>
        public bool IsBlackAndWhite
        {
            get { return ReleaseYear <= ReleaseYearForColor; }
            //set { }
        }

        public string TestAccessibility
        {
            get { return "";}
            private set { }
        }

        //Fields - data to be stored
        //never make fields public!!
        private string _title = "";
        private string _description = "";
        //private int _releaseYear = 1900;
        private string _rating = "";
        //private bool _hasSeen;
        //private int _runLength;

        /// <summary> Validates the movie. /// </summary>
        /// <returns> An error message if validation fails or empty string otherwise. </returns>
        public string Validate()
        {
            //this is implicit first parameter, represents instance
            var title = "";
            
            //Name is required //
            if (String.IsNullOrEmpty (this.Title))
                return "Title is required.";

            //Release year >= 1900
            if (ReleaseYear < 1900)
                return "Release Year must be >= 1900";

            //Run length > 0
            if (RunLength < 0)
                return "Run Length must be >= 0";

            //Rating is required
            if (String.IsNullOrEmpty (Rating))
                return "Rating is required";

            return "";
        }

        //Can new up other objects
        //private Movie originalMovie = new Movie ();
    }
}
