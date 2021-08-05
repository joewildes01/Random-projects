using System;
using System.Linq;

namespace LoveCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int love = rnd.Next(1, 100);
            char[] Twenty = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' };

            Console.WriteLine("Input the name of the first person");
            string Firstname = Console.ReadLine();
            Console.WriteLine("Input the name of the second person");
            string Secondname = Console.ReadLine();

            Console.WriteLine("{0} and {1} love each other {2}%",Firstname,Secondname,love);
            Console.ReadLine();

            if (Firstname.Contains('a') || Firstname.Contains('b') || Firstname.Contains('c'))
            {
                love += 20;
            }


        }
    }
}
