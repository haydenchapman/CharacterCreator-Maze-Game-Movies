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
            string title;
            int runLength;
            int releaseYear;
            string description;
            bool haveSeen;

            while (true)
            {
                char input = DisplayMenu ();
                if (input == 'A')
                    AddMovie ();
                else if (input == 'Q')
                    break;
            };
        }

        static void AddMovie ()
        {
            //Get title
            Console.WriteLine ("Title: ");
            string title = Console.ReadLine ();

            //Get description
            Console.WriteLine ("Description: ");
            string description = Console.ReadLine ();

            //Get release year
            int releaseYear = ReadInt32 ("Release year: ");

            //Get run length
            int runLength = ReadInt32 ("Run length (in minutes): ");

            //Get have seen
            bool haveSeen = ReadBoolean ("Have seen? ");
        }

        static int ReadInt32 ( string message )
        {
            while (true)
            {
                Console.WriteLine (message);

                string input = Console.ReadLine ();

                //int result = Int32.Parse (input);
                //int result;
                //if (Int32.TryParse (input, out result))
                if (Int32.TryParse (input, out int result))

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
            }
        }

        static char DisplayMenu ()
        {
            do
            {
                Console.WriteLine ("A)dd Movie");
                Console.WriteLine ("Q)uit");

                string input = Console.ReadLine ();

                if (input == "A" || input == "a")
                {
                    return 'A';
                } else if (input == "Q" || input == "q")
                {
                    return 'Q';
                } else
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
    }
}
