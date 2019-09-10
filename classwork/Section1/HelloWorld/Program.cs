/*
 * HI MY NAME IS
 * YOYOYOYOYOYOYOYOYOYO
 */

using System;

namespace HelloWorld
{
    class Program
    {

        static void Main ( /*string[] args*/ )
        {
            //movie data
            //string title;
            //int runLength;
            //int releaseYear;
            //string description;
            //bool haveSeen;

            var quit = false;
            while (!quit)
            {
                char input = DisplayMenu ();
                switch (input)
                {
                    //fallthrough if case is emput
                    case 'a':
                    case 'A': AddMovie (); break;

                    //must include break/return at end of case
                    case 'D': DisplayMovie (); break;
                    case 'R': RemoveMovie (); break;
                    case 'Q':
                    {
                        break;
                    }
                    default: Console.WriteLine ("Not supported"); break;
                };
              
                if (input == 'A')
                    AddMovie ();
                else if (input == 'D')
                    DisplayMovie ();
                else if (input =='R')
                    RemoveMovie();
                else if (input == 'Q')
                    break;

                //char input = DisplayMenu ();
                //if (input == 'A')
                //    AddMovie ();
                //else if (input == 'D')
                //    DisplayMovie ();
                //else if (input =='R')
                //    RemoveMovie ();
                //else if (input == 'Q')
                //   break;
            };
        }

        private static void RemoveMovie()
        {
            //Confirm removal
            //DO NOT do this == true, expression
            if (ReadBoolean ($"Are you sure you want to remove {title}"))
                return;

            //Remove movie
            title = null;
        }
        static void AddMovie ()
        {
            //Get title
            Console.WriteLine ("Title: ");
             title = Console.ReadLine ();

            //Get description
            Console.WriteLine ("Description: ");
             description = Console.ReadLine ();

            //Get release year
             releaseYear = ReadInt32 ("Release year: ");

            //Get run length
             runLength = ReadInt32 ("Run length (in minutes): ");

            //Get have seen
             hasSeen = ReadBoolean ("Have seen? ");
        }

        static void DisplayMovie()
        {
            //Display messagae if no movies
            if(String.IsNullOrEmpty(title))
            {
                Console.WriteLine ("No Movies");
                return;
            }

            //title, desc, release year, run length, hasSeen
            Console.WriteLine (title);
            Console.WriteLine (description);

            //Formatting Strings
            //1) string concat
            Console.WriteLine ("Released " + releaseYear);

            //2)Printf equiv
            //Console.WriteLine ("Run time: {0}", runLength);

            //3) String formatting
            var formattedString = String.Format("Run time: {0}", runLength);
            Console.WriteLine (formattedString);

            //4) String interpolation
            Console.WriteLine ($"Seen it? {hasSeen}");

            Console.WriteLine ("".PadLeft (50, '-'));
        }

        static int ReadInt32 ( string message )
        {
            while (true)
            {
                Console.WriteLine (message);

                var input = Console.ReadLine ();

                //int result = Int32.Parse (input);
                //int result;
                //if (Int32.TryParse (input, out result))
                if (Int32.TryParse (input, out var result))
                    return result;

                Console.WriteLine ("Not a number");
            }
        }

        static bool ReadBoolean ( string message )
        {
            while (true)
            {
                Console.WriteLine (message);

                string input = Console.ReadLine ();

                bool result;
                if (Boolean.TryParse (input, out result))
                    return result;

                Console.WriteLine ("Not a boolean");
            };
        }

        static char DisplayMenu ()
        {
            do
            {
                Console.WriteLine ("A)dd Movie");
                Console.WriteLine ("D)isplay Movie");
                Console.WriteLine ("Q)uit");
                Console.WriteLine ("R)emove Movie");

                string input = Console.ReadLine ();

                //Lower case
                input = input.ToLower();
                //if (input == "A" || input == "a")
                //if (input == "a")
                if (String.Compare (input, "a", true) == 0)
                {
                    return 'A';
                } else if (input == "q")
                {
                    return 'Q';
                } else if (input == "d")
                    return 'D';
                else if (input == "r")
                    return 'R';
                else
                {
                    Console.WriteLine ("Invalid input");
                };

            } while (true);
        }



        private static string DemoLanguage ()
        {
            string name = "";

            //(string if = "";) cannot use keywords as ID

            //Definitely assigned
            //name = "Bob";

            string name2 = Console.ReadLine ();

            Console.WriteLine (name2);

            name2 = name = "Sue";
            Console.WriteLine (name2);
            Console.WriteLine ("Hello World!");

            //another block

            int hours = 8;
            double payRate = 15.25;

            double totalPay = payRate * hours;

            string fullName = "Fred" + " " + "Jones";
            return fullName;
        }

        static void DemoArray ()
        {
            double[] payRates = new double[100];

            //50th elemenet to 7.25
            payRates[49] = 7.25;

            //read 89th element into temp variable
            double payRate = payRates[88];
            Console.WriteLine (payRates[79]);

            //An empty array
            bool[] isPassing = new bool[0];

            //Enumerating an array
            for (int index = 0; index < payRates.Length; ++index)
                Console.WriteLine (payRates[index]);

            //type inferencing
            //string name = "Bob William Smith Jr. III";
            var name = "Bob William Smith Jr. III";
            string[] nameParts = name.Split(' ');


        }

        static void DemoString()
        {
            string str = null;

            //checking for null
            if (str != null )
                str = str.ToLower ();

            //checking for null or empty string
            if (str != null && str != "")
                str = str.ToLower ();

            //Length - DO NOT
            if (str != null && str.Length == 0)
                str = str.ToLower ();

            //Empty - DO NOT
            if (str != null && str != String.Empty)
                str = str.ToLower ();

            //correct approach
            if (!String.IsNullOrEmpty(str))
                str = str.ToLower();




        }

        // Do not declare global variable outside lab1
        static string title;
        static string description;
        static int runLength;
        static int releaseYear;
        static bool hasSeen;
    }
}
