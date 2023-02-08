using System.Net.Http.Headers;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string FavSubject = Console.ReadLine();

            switch (FavSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is the best");
                break;
                case "biology":
                    Console.WriteLine("Biology is the best");
                break;
                case "physics":
                    Console.WriteLine("physics rules");
                break;
                case "history":
                    Console.WriteLine("Interesting");
                break;
                case "music":
                    Console.WriteLine("Nice!");
                    break;
                default:
                    Console.WriteLine("Please enter a subject");
                break;


            }

        }
    }
}