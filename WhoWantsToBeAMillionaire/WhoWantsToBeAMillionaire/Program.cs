using System;
using System.Linq;
using System.Threading;

namespace WhoWantsToBeAMillionaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Good Evening!, Welcome to Who Wants to be a Millionaire!");
            Console.WriteLine("Press enter to begin");
            Console.WriteLine("------------------------------------------------------------");
            Console.ReadLine();


            Console.WriteLine("And who is it playing tonight?");
            Console.WriteLine("Please Enter your name:");
            string Player = Console.ReadLine();
            Console.WriteLine("Okay {0}, Lets play who wants to be a millionaire", Player);

            Thread.Sleep(1000);
            Console.Write("DUN");
            Thread.Sleep(1000);
            Console.Write("DUN");
            Thread.Sleep(1000);
            Console.Write("DUN");
            Thread.Sleep(1000);

            Console.WriteLine("Question 1 - Who became the 26th President of the United States in 1901?");
            Thread.Sleep(1000);
            Console.WriteLine("Was it...");
            Thread.Sleep(1000);
            Console.WriteLine("a - William Taft");
            Console.WriteLine("b - Franklin.D.Roosevelt");
            Console.WriteLine("c - Theodore Roosevelt");
            Console.WriteLine("d - William McKinley");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "a":
                    goto fail100;
                case "b":
                    goto fail100;
                case "c":
                    goto win100;
                case "d":
                    goto fail100;
                


                default:
                    break;
            }

        fail100:
            Console.WriteLine("Sorry but thats incorrect");

        win100:
            Console.WriteLine("Congratulations you won £100 ");

            





        }
    }
}
