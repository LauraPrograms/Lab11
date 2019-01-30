using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> MovieList = new List<Movie>();
            MovieList.Add(new Movie("Annihilation", "scifi"));
            MovieList.Add(new Movie("Black Panther", "scifi"));
            MovieList.Add(new Movie("Ready Player One", "scifi"));
            MovieList.Add(new Movie("A Star is Born", "drama"));
            MovieList.Add(new Movie("Roma", "drama"));
            MovieList.Add(new Movie("Eighth Grade", "drama"));
            MovieList.Add(new Movie("Incredible 2", "animated"));
            MovieList.Add(new Movie("Spider-Man into the Spider-Verse", "animated"));
            MovieList.Add(new Movie("A Quiet Place", "horror"));
            MovieList.Add(new Movie("Overlord", "horror"));

            Console.WriteLine("Welcome to the Movie List Application!");
            string MovieCategory = "";
            bool run = true;
            while (run)
            {
                Console.WriteLine("There are 10 movies in this list in the following categories:" + "\n" + "1. scifi" + "\n" + "2. horror" + "\n" + "3. drama" + "\n" + "4. animated");
                Console.WriteLine("What category are you interested in? (type in 1-4)");
                string userInput = Console.ReadLine();
                bool valid = false;
                if (userInput == "1")
                {
                    MovieCategory = "scifi";
                    valid = true;
                }
                else if (userInput == "2")
                {
                    MovieCategory = "horror";
                    valid = true;

                }
                else if (userInput == "3")
                {
                    MovieCategory = "drama";
                    valid = true;

                }
                else if (userInput == "4")
                {
                    MovieCategory = "animated";
                    valid = true;

                }
                else
                {
                    Console.WriteLine("Oh bless your heart, sweetie. I did not understand.");
                }
                if (valid == true)
                {
                    foreach (Movie film in MovieList)
                    {
                        if (film.MovieMatch(MovieCategory))
                        {
                            film.PrintMovieName();
                        }
                    }
                    run = Continue();
                }
            }

        }
        public static bool Continue()
        {
            Console.WriteLine("Would you like to Continue? (y/n)");
            string answer = Console.ReadLine().ToLower();
            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                return false;
            }
            else
            {
                return Continue();
            }
        }

    }
}
