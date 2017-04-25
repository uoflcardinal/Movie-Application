using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.WriteLine("Welcome to the Movie List Application!");

                Movie[] ListOfMovies = new Movie[10];

                ListOfMovies[0] = new Movie("Edge of Tomorrow", "scifi");
                ListOfMovies[1] = new Movie("Dawn of the Planet of the Apes", "scifi");
                ListOfMovies[2] = new Movie("Children of Men", "scifi");
                ListOfMovies[3] = new Movie("The Exorcist", "horror");
                ListOfMovies[4] = new Movie("The Blair Witch Project", "horror");
                ListOfMovies[5] = new Movie("The Conjuring", "horror");
                ListOfMovies[6] = new Movie("Finding Nemo", "antimated");
                ListOfMovies[7] = new Movie("The Incredibles", "antimated");
                ListOfMovies[8] = new Movie("Forrest Gump", "drama");
                ListOfMovies[9] = new Movie("A Beautiful Mind", "drama");

                Console.WriteLine("There are 10 movies in the list.");
                Console.Write("What category are you interested in: antimated, horror, drama, or scifi?  ");
                string input = Console.ReadLine().ToLower();


                foreach (Movie temp in ListOfMovies)
                {
                    if (input == temp.MovieCategory)
                    {
                        Console.WriteLine(temp.MovieTitle);
                    }
                }   

                char choice;
                Console.WriteLine("Do you want to continue? (y/n): ");
                while (!char.TryParse(Console.ReadLine(), out choice)) ;

                if (choice == 'y')
                {
                    continue;
                }
                else if (choice == 'n')
                {
                    return;
                }
                else if (choice != 'y' || choice != 'n')
                {
                    Console.WriteLine("You did not enter 'y' or 'n'!  Please try again.");
                }
              
            } while (true);
        }
    }
}
