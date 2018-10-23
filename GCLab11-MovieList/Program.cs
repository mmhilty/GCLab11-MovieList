using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab11_MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie MrSmith = new Movie("Mr Smith Goes to Washington", "DRAMA");
            Movie AllQuiet = new Movie("All Quiet on the Western Front", "DRAMA");
            Movie GoneWind= new Movie("Gone With the Wind", "DRAMA");
            Movie Frankenstein = new Movie("Frankenstein", "HORROR");
            Movie FrankenBride = new Movie("Bride of Frankenstein", "HORROR");
            Movie Dracula = new Movie("Dracula", "HORROR");
            Movie Flash = new Movie("Flash Gordon", "SCIFI");
            Movie ThingsCome = new Movie("Things to Come", "SCIFI");
            Movie CosmicVoyage = new Movie("Cosmic Voyage", "SCIFI");
            Movie SnowWhite = new Movie("Snow White", "ANIMATED");

            List<Movie> movieList = new List<Movie>() {MrSmith, AllQuiet, GoneWind,
                FrankenBride, Frankenstein, Dracula,
                Flash, ThingsCome, CosmicVoyage, SnowWhite};

            // got the list now
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine($"There are {movieList.Count()} movies to choose from! \n");

            bool killswitch = true;
            while (killswitch)
            {
                bool showContinue = true;
                string MainMenuChoice = MainMenuMethod();
                if (MainMenuChoice == "EXIT")
                {
                    showContinue = false;
                    killswitch = ContinueExitMethod("EXIT");
                }

                else if (MainMenuChoice == "ALL")
                {
                    Console.WriteLine("\n Here are all the movies we have in this library: \n");
                    PrintListMethod(movieList);
                }

                else
                {
                    GenreSearchMethod(movieList, MainMenuChoice);
                }


                if (showContinue == true)
                { killswitch = ContinueExitMethod("CONTINUE"); }

            }

        }
        public static string MainMenuMethod()
        {
            while (true)
            {
                Console.WriteLine($"What would you like to do? \n" +
                        $"  1. View All Movies \n" +
                        $"  2. View All SciFi Movies \n" +
                        $"  3. View All Drama Movies \n" +
                        $"  4. View All Animated Movies \n" +
                        $"  5. View ALl Horror Movies \n" +
                        $"  6. Exit \n");
                Console.Write("Enter the number of your chosen option: ");
                string mainMenuCommand = Console.ReadLine();
                switch (mainMenuCommand)
                {
                    case "1":
                        return "ALL";                        
                    case "2":
                        return "SCIFI";
                    case "3":
                        return "DRAMA";
                    case "4":
                        return "ANIMATED";
                    case "5":
                        return "HORROR";
                    case "6":
                        return "EXIT";
                    default:
                        Console.WriteLine("Not a valid option. Please choose an option from the list above via number.");
                        break;

                }
            }

        }

        public static void GenreSearchMethod(List<Movie> movieList, string searchTerm)
        {
            List<Movie> searchResultList = new List<Movie>();

            
            foreach (Movie m in movieList)
            {
                if (m.genre == searchTerm.ToUpper())
                {
                    searchResultList.Add(m);
                }
            }

            Console.WriteLine($"\n Here are all the movies we have in the {searchTerm.ToLower()} genre: \n");
            PrintListMethod(searchResultList);
            

        }

        public static void PrintListMethod(List<Movie> movieList)
        {
            foreach (Movie m in movieList.OrderBy(m => m.title))
            {
                Console.WriteLine($"- {m.title}");

            }
            Console.WriteLine();
        }

        public static bool ContinueExitMethod(string exitchoice)
        {
            if (exitchoice == "CONTINUE")
            {
                while (true)
                {
                    Console.WriteLine("\nWould you like to continue? Enter Y to continue or N to exit");
                    string continueInput = Console.ReadLine();
                    if (continueInput.ToUpper() == "Y")
                    {
                        return true;
                    }
                    else if (continueInput.ToUpper() == "N")
                    {
                        Console.WriteLine("Thanks for using the Movie List Application! \n" +
                                "Exiting in ");
                        DotDotDot();
                        return false;
                    }
                    else
                    {
                        Console.WriteLine("Not sure what you mean. Try again, please!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Thanks for using the Movie List Application! \n" +
                                "Exiting in ");
                DotDotDot();
                return false;
            }

        }

        public static void DotDotDot()
        {
            System.Threading.Thread.Sleep(500);
            Console.Write("3 ");
            System.Threading.Thread.Sleep(500);
            Console.Write("2 ");
            System.Threading.Thread.Sleep(500);
            Console.Write("1 \n");
            System.Threading.Thread.Sleep(500);
        }



    }
}
