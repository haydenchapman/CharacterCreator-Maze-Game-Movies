/******************************************
 * Itse1430 Lab1 - Author: Hayden Chapman
 * This is a simple command line maze game.
 * Location names Star Trek inspired.
 ******************************************
 */
using System;

namespace Itse1430.Maze
{
    class Program
    {
        private static int s_directionFacing;
        static void Main ( string[] args )
        {
            Console.WriteLine ("".PadLeft (45, '-'));
            Console.WriteLine ("     ___....-----'---'-----....___");
            Console.WriteLine ("=========================================");
            Console.WriteLine ("       ___'---..._______...---'___       ");
            Console.WriteLine ("      (___)      _|_|_|_      (___)      ");
            Console.WriteLine ("        \\____.-'_.---._'-.____//         ");
            Console.WriteLine ("          cccc'.__'---'__.'cccc      ");
            Console.WriteLine ("                  ccccc");
            Console.WriteLine ("".PadLeft (45, '-'));
            Console.WriteLine ("Welcome to the Starship Maze.");
            Console.WriteLine ("The Starship you are aboard has been attacked!");
            Console.WriteLine ("You must find your way to the escape pod!");
            Console.WriteLine ("Please enter the valid commands to navigate.");
            Console.WriteLine ("".PadLeft (45, '-'));
            Console.WriteLine ("Press 'Enter' to begin:");
            Console.ReadLine ();
            Console.Clear ();
            s_directionFacing = 1;
            Room1 ();
        }
        static CardinalDirection Movement (AvailableCommand Command)
            {
            switch (Command)
            {
                
                case AvailableCommand.MoveLeft:
                return (CardinalDirection)((s_directionFacing - 1 + 4) % 4);
                case AvailableCommand.MoveRight:
                return (CardinalDirection)((s_directionFacing + 1 + 4) % 4);
                case AvailableCommand.MoveBackward:
                return (CardinalDirection)((s_directionFacing + 2 + 4) % 4);
                case AvailableCommand.MoveForward:
                return (CardinalDirection)s_directionFacing;
            }
            return (CardinalDirection)s_directionFacing;
        }
        static AvailableCommand CommandHandler()
        {
            while(true)
            {
                Console.WriteLine ("".PadLeft (45, '-'));
                Console.WriteLine ("Where will you go?");
                Console.WriteLine ("The available movement commands are: 'move forward', 'move backward', 'move right', 'move left'");
                Console.WriteLine ("The available looking commands are: 'look left', 'look right', 'turn around'");
                Console.WriteLine ("".PadLeft (45, '-'));
                string Command = CommandValid ();
                switch (Command)
                {
                    case "Quit":
                    {
                        if (BoolValid ("Are you sure you would like to quit?"))
                            return AvailableCommand.Quit;
                        else
                            continue;
                    }
                    case "move forward":
                    return AvailableCommand.MoveForward;
                    case "move backward":
                    return AvailableCommand.MoveBackward;
                    case "move right":
                    return AvailableCommand.MoveRight;
                    case "move left":
                    return AvailableCommand.MoveLeft;

                    case "look right":
                    s_directionFacing = (s_directionFacing + 1 + 5) % 5;
                    DisplayDirection ();
                    break;

                    case "look left":
                    s_directionFacing = (s_directionFacing - 1 + 5) % 5;
                    DisplayDirection ();
                    break;

                    case "turn around":
                    s_directionFacing = (s_directionFacing + 1 + 5) % 5;
                    break;

                    default:
                    {
                        Console.WriteLine ("Invalid input. Please enter a valid command");
                        continue;
                    }
                }
            }
        }
        enum CardinalDirection
        {
            North = 1,
            East = 2,
            South = 3,
            West = 4,
        }
        enum AvailableCommand
        {
            MoveForward = 2,
            MoveBackward = 3,
            MoveLeft = 4,
            MoveRight = 5,
            Quit = 1
        }
        static string CommandValid()
        {
            while (true)
            {
                string input = Console.ReadLine ();
                input = input.Trim ();
                input = input.ToLower ();
                if (String.IsNullOrEmpty (input))
                    continue;    
                return input;
            }

        }
        static bool BoolValid(string Information)
        {
            while (true)
            {
                Console.WriteLine (Information);
                string input = Console.ReadLine ();
                bool result;
                if (Boolean.TryParse (input, out result))
                    return result;
                Console.WriteLine ("Not a True/False");
            }
        }
        static void DisplayDirection ()
        {
            while (true)
            {
                Console.WriteLine ("".PadLeft (45, '-'));
                Console.WriteLine ("You are currently facing " + (CardinalDirection)s_directionFacing + ".");
                Console.WriteLine ("".PadLeft (45, '-'));
                return;
            }
        }
        public static void Room1()
        {
            Console.WriteLine ("".PadLeft (45, '-'));
            Console.WriteLine ("     ___....-----'---'-----....___");
            Console.WriteLine ("=========================================");
            Console.WriteLine ("       ___'---..._______...---'___       ");
            Console.WriteLine ("      (___)      _|_|_|_      (___)      ");
            Console.WriteLine ("        \\____.-'_.---._'-.____//         ");
            Console.WriteLine ("          cccc'.__'---'__.'cccc      ");
            Console.WriteLine ("                  ccccc");
            Console.WriteLine ("".PadLeft (46, '-'));
            Console.WriteLine ("You are on the bridge of your starship.");
            Console.WriteLine ("Everything is on fire! RED ALERT! RED ALERT!");
            Console.WriteLine ("You have found the captain dead!");
            Console.WriteLine ("All hope has been lost! Abandon ship!");
            Console.WriteLine ("".PadLeft (46, '-'));
            Console.WriteLine ("Press 'Enter' to continue...");
            Console.ReadLine ();
            Console.WriteLine ("".PadLeft (45, '-'));

            while (true)
            {
                AvailableCommand command = CommandHandler ();

                CardinalDirection direction;

                if (command == AvailableCommand.Quit)
                    return;
                else
                {
                    direction = Movement (command);
                       
                        switch (direction)
                        {
                        case CardinalDirection.North:
                        Room5 ();
                        return;

                        case CardinalDirection.South:
                        Console.WriteLine ("There is no way out! You are only looking into the vastness of space.");
                        break;

                        case CardinalDirection.East:
                        Room3 ();
                        return;

                        case CardinalDirection.West:
                        Room2 ();
                        return;
                        }
                        
                }
            }
            
        }
        public static void Room2()
        {
            DisplayDirection ();
            Console.WriteLine ("".PadLeft (45, '-'));
            Console.WriteLine ("You have entered the Captain's Quarters");
            Console.WriteLine ("There is no way out from here!");
            Console.WriteLine ("The escape pod is on the opposite side of the ship! You must turn around!");
            Console.WriteLine ("".PadLeft (45, '-'));
            while (true)
            {
                AvailableCommand command = CommandHandler ();
                CardinalDirection direction;
                if (command == AvailableCommand.Quit)
                    return;
                else
                {
                    direction = Movement (command);
                    switch (direction)
                    {
                        case CardinalDirection.North:
                        Console.WriteLine ("There is a wall here! Look for another way!");
                        break;

                        case CardinalDirection.South:
                        Console.WriteLine ("There is a wall here! Look for another way!");
                        break;

                        case CardinalDirection.West:
                        Console.WriteLine ("TThere is a wall here! Look for another way!");
                        break;

                        case CardinalDirection.East:
                        Room1 ();
                        return;
                    }
                }
            } 
        }
        public static void Room3 ()
        {

            Console.WriteLine ("".PadLeft (45, '-'));
            Console.WriteLine ("You have entered the Main Computer Deck.");
            
            DisplayDirection ();

            while (true)
            {
                AvailableCommand command = CommandHandler ();
                CardinalDirection direction;
                if (command == AvailableCommand.Quit)
                    return;
                else
                {
                    direction = Movement (command);
                    switch (direction)
                    {
                        case CardinalDirection.North:
                        Console.WriteLine ("There is a wall here! Look for another way!");
                        break;

                        case CardinalDirection.South:
                        Console.WriteLine ("There is a wall here! Look for another way!");
                        break;

                        case CardinalDirection.West:
                        Room1 ();
                        return;

                        case CardinalDirection.East:
                        Room4 ();
                        return;
                    }
                }
            }
        }
        public static void Room4 ()
        {
            Console.WriteLine ("".PadLeft (45, '-'));
            DisplayDirection ();
            Console.WriteLine ("You have entered the Crew Deck.");
            
            while (true)
            {
                AvailableCommand command = CommandHandler ();
                CardinalDirection direction;
                if (command == AvailableCommand.Quit)
                    return;
                else
                {
                    direction = Movement (command);
                    switch (direction)
                    {
                        case CardinalDirection.North:
                        Room6 ();
                        break;

                        case CardinalDirection.South:
                        Console.WriteLine ("There is a wall here! Look for another way!");
                        break;

                        case CardinalDirection.West:
                        Room3 ();
                        return;

                        case CardinalDirection.East:
                        Console.WriteLine ("There is a wall here! Look for another way!");
                        return;
                    }
                }
            }
        }
        public static void Room5 ()
        {
            Console.WriteLine ("".PadLeft (45, '-'));
            Console.WriteLine ("You have entered the Life Support Deck.");
            
            DisplayDirection ();

            while (true)
            {
                AvailableCommand command = CommandHandler ();
                CardinalDirection direction;
                if (command == AvailableCommand.Quit)
                    return;
                else
                {
                    direction = Movement (command);
                    switch (direction)
                    {
                        case CardinalDirection.North:
                        Room7 ();
                        return;

                        case CardinalDirection.South:
                        Room5 ();
                        return;

                        case CardinalDirection.West:
                        Console.WriteLine ("There is a wall here! Look for another way!");
                        break;

                        case CardinalDirection.East:
                        Console.WriteLine ("There is a wall here! Look for another way!");
                        break;
                    }
                }
            }
        }
        public static void Room6 ()
        {
            Console.WriteLine ("".PadLeft (45, '-'));
            Console.WriteLine ("You have entered the Recreation Deck.");
            

            while (true)
            {
                AvailableCommand command = CommandHandler ();
                CardinalDirection direction;
                if (command == AvailableCommand.Quit)
                    return;
                else
                {
                    direction = Movement (command);
                    switch (direction)
                    {
                        case CardinalDirection.North:
                        Room9 ();
                        return;

                        case CardinalDirection.South:
                        Room6 ();
                        return;

                        case CardinalDirection.West:
                        Console.WriteLine ("There is a wall here! Look for another way!");
                        break;

                        case CardinalDirection.East:
                        Room13 ();
                        return;

                    }
                }
            }
        }
        public static void Room7 ()
        {
            Console.WriteLine ("".PadLeft (45, '-'));
            Console.WriteLine ("You have entered the Armory.");
            
            while (true)
            {
                AvailableCommand command = CommandHandler ();
                CardinalDirection direction;
                if (command == AvailableCommand.Quit)
                    return;
                else
                {
                    direction = Movement (command);
                    switch (direction)
                    {
                        case CardinalDirection.North:
                        Console.WriteLine ("There is a wall here! Look for another way!");
                        break;

                        case CardinalDirection.South:
                        Room5 ();
                        return;

                        case CardinalDirection.West:
                        Console.WriteLine ("There is a wall here! Look for another way!");
                        break;

                        case CardinalDirection.East:
                        Room8 ();
                        return;
                    }
                }
            }
        }
        public static void Room8 ()
        {
            Console.WriteLine ("".PadLeft (45, '-'));
            Console.WriteLine ("You have entered the Admin Deck.");
            
            while (true)
            {
                AvailableCommand command = CommandHandler ();
                CardinalDirection direction;
                if (command == AvailableCommand.Quit)
                    return;
                else
                {
                    direction = Movement (command);
                    switch (direction)
                    {
                        case CardinalDirection.North:
                        Console.WriteLine ("There is a wall here! Look for another way!");
                        break;

                        case CardinalDirection.South:
                        Console.WriteLine ("There is a wall here! Look for another way!");
                        break;

                        case CardinalDirection.West:
                        Room7 ();
                        return;

                        case CardinalDirection.East:
                        Room9 ();
                        return;
                    }
                }
            }
        }
        public static void Room9 ()
        {
            Console.WriteLine ("".PadLeft (45, '-'));
            Console.WriteLine ("You have entered the Infirmary.");
            
            while (true)
            {
                AvailableCommand command = CommandHandler ();
                CardinalDirection direction;
                if (command == AvailableCommand.Quit)
                    return;
                else
                {
                    direction = Movement (command);
                    switch (direction)
                    {
                        case CardinalDirection.North:
                        Room10 ();
                        return;

                        case CardinalDirection.South:
                        Room6 ();
                        return;

                        case CardinalDirection.West:
                        Room8 ();
                        return;

                        case CardinalDirection.East:
                        Console.WriteLine ("There is a wall here! Look for another way!");
                        break;
                    }
                }
            }
        }
        public static void Room10 ()
        {
            Console.WriteLine ("".PadLeft (45, '-'));
            Console.WriteLine ("You have entered the Galley");
            
            while (true)
            {
                AvailableCommand command = CommandHandler ();
                CardinalDirection direction;
                if (command == AvailableCommand.Quit)
                    return;
                else
                {
                    direction = Movement (command);
                    switch (direction)
                    {
                        case CardinalDirection.North:
                        Console.WriteLine ("There is a wall here! Look for another way!");
                        break;

                        case CardinalDirection.South:
                        Room9 ();
                        return;

                        case CardinalDirection.West:
                        Console.WriteLine ("There is a wall here! Look for another way!");
                        break;

                        case CardinalDirection.East:
                        Room11 ();
                        return;

                    }
                }
            }
        }
        public static void Room11 ()
        {
            Console.WriteLine ("".PadLeft (45, '-'));
            Console.WriteLine ("You have entered Compartment Hold 1.");
            
            while (true)
            {
                AvailableCommand command = CommandHandler ();
                CardinalDirection direction;
                if (command == AvailableCommand.Quit)
                    return;
                else
                {
                    direction = Movement (command);
                    switch (direction)
                    {
                        case CardinalDirection.North:
                        Console.WriteLine ("There is a wall here! Look for another way!");
                        break;

                        case CardinalDirection.South:
                        Console.WriteLine ("There is a wall here! Look for another way!");
                        break;

                        case CardinalDirection.West:
                        Room10 ();
                        return;

                        case CardinalDirection.East:
                        Room12 ();
                        return;
                    }
                }
            }
        }
        public static void Room12 ()
        {
            Console.WriteLine ("".PadLeft (45, '-'));
            Console.WriteLine ("You have entered the Brig.");
            
            while (true)
            {
                AvailableCommand command = CommandHandler ();
                CardinalDirection direction;
                if (command == AvailableCommand.Quit)
                    return;
                else
                {
                    direction = Movement (command);
                    switch (direction)
                    {
                        case CardinalDirection.North:
                        Console.WriteLine ("There is a wall here. There is no way out this way!");
                        break;

                        case CardinalDirection.South:
                        Room15 ();
                        return;

                        case CardinalDirection.West:
                        Room11 ();
                        return;

                        case CardinalDirection.East:
                        Console.WriteLine ("There is a wall here. There is no way out this way!");
                        break;

                    }
                }
            }
        }
        public static void Room13 ()
        {
            Console.WriteLine ("".PadLeft (45, '-'));
            Console.WriteLine ("You have entered Compartment Hold 2.");
            
            while (true)
            {
                AvailableCommand command = CommandHandler ();
                CardinalDirection direction;
                if (command == AvailableCommand.Quit)
                    return;
                else
                {
                    direction = Movement (command);
                    switch (direction)
                    {
                        case CardinalDirection.North:
                        Console.WriteLine ("There is a wall here! Look for another way!");
                        break;

                        case CardinalDirection.South:
                        Console.WriteLine ("There is a wall here! Look for another way!");
                        break;

                        case CardinalDirection.West:
                        Room6 ();
                        return;

                        case CardinalDirection.East:
                        Room14 ();
                        return;
                    }
                }
            }
        }
        public static void Room14 ()
        {
            Console.WriteLine ("".PadLeft (45, '-'));
            Console.WriteLine ("You have entered the Engineering Bay");
            
            while (true)
            {
                AvailableCommand command = CommandHandler ();
                CardinalDirection direction;
                if (command == AvailableCommand.Quit)
                    return;
                else
                {
                    direction = Movement (command);
                    switch (direction)
                    {
                        case CardinalDirection.North:
                        Room15 ();
                        return;

                        case CardinalDirection.South:
                        Console.WriteLine ("There is a wall here! Look for another way!");
                        break;

                        case CardinalDirection.West:
                        Room13 ();
                        return;

                        case CardinalDirection.East:
                        Console.WriteLine ("There is a wall here! Look for another way!");
                        return;

                    }
                }
            }
        }
        public static void Room15 ()
        {
            Console.WriteLine ("".PadLeft (45, '-'));
            Console.WriteLine ("You have entered the Main Engine Room");
            
            while (true)
            {
                AvailableCommand command = CommandHandler ();
                CardinalDirection direction;
                if (command == AvailableCommand.Quit)
                    return;
                else
                {
                    direction = Movement (command);
                    switch (direction)
                    {
                        case CardinalDirection.North:
                        Room12 ();
                        return;

                        case CardinalDirection.South:
                        Room14 ();
                        return;

                        case CardinalDirection.West:
                        Console.WriteLine ("There is a wall here! Look for another way!");
                        break;

                        case CardinalDirection.East:
                        Room16 ();
                        return;

                    }
                }
            }
        }
        public static void Room16()
        {
            Console.WriteLine ("".PadLeft (45, '-'));
            Console.WriteLine ("You have entered the Escape Pod Bay!");
            Console.WriteLine ("CONGRADULATIONS! YOU HAVE FOUND THE ESCAPE POD!");
            Console.WriteLine ("NOW LETS GET OUT OF HERE!");
            Console.WriteLine ("".PadLeft (45, '-'));
            Console.WriteLine ("Press enter to end.");
            Console.ReadLine ();
            Console.Clear ();
            GameOver();

        }
        public static void GameOver()
        {
            Console.WriteLine ("Congratulations! YOU HAVE WON!");
            Console.WriteLine ("We are on our way to the nearest starbase!");
            Console.WriteLine ("Press enter to exit the game.");
            Console.ReadLine ();
            System.Environment.Exit (0);
        }
    }
}
