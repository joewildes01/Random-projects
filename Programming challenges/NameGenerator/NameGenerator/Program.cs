using System;

namespace NameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] FirstName = { "Peter","Gary","Daniel","Louis","Simon","Alan","Paul","Brian","Michael","Boris"};
            string[] LastName = { "Anderson","Aaronson","Mayer","Stevens","Parin","Quest","Gorn","Barringer" };
            bool happy = false;
            Random rnd = new Random();


            while (happy == false)
            {
                Console.WriteLine("Press enter to generate a name");

                Console.ReadLine();
                int FirstValue = rnd.Next(0, FirstName.Length);
                int SecondValue = rnd.Next(0, LastName.Length);


                

                Console.WriteLine($"{FirstName[FirstValue]} {LastName[SecondValue]}");

                Console.WriteLine();
                Console.WriteLine("Are you happy with this name?");
                Console.WriteLine("1 - yes / 2 - no");
                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    happy = true;
                }
                else
                {
                    happy = false;
                }

            }

            
        }
    }
}
