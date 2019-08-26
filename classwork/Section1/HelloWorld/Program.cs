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

            Console.WriteLine (fullName);

        }

    }
}
