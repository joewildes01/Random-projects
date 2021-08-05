using System;
using System.Threading;

namespace Magic8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            int Milliseconds = 2000;
            Random rnd = new Random();

            string[] Answers = { "Not Likely", "Maybe Someday", "Definitely yes", "Don't get your hopes up", "I dont think so", "Try again later", "I have never been more certain", "Yes" };
            bool again = true;

            do
            {
                
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Welcome to the wonderous 8 ball");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Press enter to begin!");
                Console.ReadLine();

                Console.WriteLine("Enter your question");
                string UserQuestion = Console.ReadLine();

                Console.WriteLine("Press enter to shake the 8 ball");
                Console.ReadLine();

                Console.WriteLine("*Shake*");
                Thread.Sleep(Milliseconds);
                Console.WriteLine("*Shake*");
                Thread.Sleep(Milliseconds);
                Console.WriteLine("...");
                Thread.Sleep(Milliseconds);

                int TheAnswer = rnd.Next(0, Answers.Length);

                Console.WriteLine($"{Answers[TheAnswer]}");

                Thread.Sleep(Milliseconds);

                Console.WriteLine("Ask another question?");
                Console.Write("1 - Yes");
                Console.Write(" 2 - No");
                Console.WriteLine();

                int decision = int.Parse(Console.ReadLine());

                if (decision == 1)
                {
                    again = true;

                }
                else
                {
                    again = false;
                }



            } while (again == true);
            




        }
    }
}
