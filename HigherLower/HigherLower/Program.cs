using System;

namespace HigherLower
{
    class Program
    {
        static void Main(string[] args)
        {

            int Heads = 0;
            int Tails = 0;
            int timesFlipped = 0;
            bool Done = false;

            
                Random rnd = new Random();

                string[] coin = { "Heads", "Tails" };

                

            do
            {

                int flip = rnd.Next(0, coin.Length);



                if (coin[flip] == "Tails")
                {
                    Tails++;
                    timesFlipped++;

                }
                if (coin[flip] == "Heads")
                {
                    Heads++;
                    timesFlipped++;
                }
                if (timesFlipped == 100)
                {
                    Done = true;
                }
            } while (Done == false);



            Console.WriteLine("Times coin was heads = {0}", Heads);
            Console.WriteLine("Times coin was tails = {0}", Tails);
            



        }
    }
}
