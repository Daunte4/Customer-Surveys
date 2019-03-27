using System;
using System.Threading;

namespace Survey
{
    class Program
    {
        private static string leave;

        static void Main(string[] args)
        {

            string leave = "";
            bool check = false;
            {


                Console.WriteLine("What is your name?");
                var name = Console.ReadLine();

                Console.WriteLine("What is your age?");
                var age = Console.ReadLine();

                Console.WriteLine("Why do you like Coding?");
                var coding = Console.ReadLine();

                Console.WriteLine("Your name is: {0}", name);
                Console.WriteLine("Your age is: {0}", age);
                Console.WriteLine("Your answer is: {0}", coding);

                Console.WriteLine("=======================================================");
                Console.WriteLine("");
                Thread.Sleep(3000);
                Console.WriteLine("Thanks for Participating");
                Console.WriteLine("=======================================================");

                Console.WriteLine("\nDo you want to leave yes or no?" + "\n 1.Yes" + " 2. No");
                Console.WriteLine("\nMy option is: ");
                leave = Console.ReadLine();
                switch (leave)
                {
                    case "1":
                        Console.WriteLine("you chose Yes.");
                        check = true;
                        break;
                        
                    case "2":
                        Console.WriteLine("you chose No.");
                        check = true;
                        break;

                    default:
                        Console.WriteLine("invalid choice.");
                        check = false;
                        break;
                }
            }



        }

    }
}
