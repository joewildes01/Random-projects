using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string Reverse = "Reverse me!";
            Console.WriteLine(Reverse);

            char[] banana = Reverse.ToCharArray();

            

            for (int i = banana.Length - 1; i > -1; i--)
            {
                Console.Write("{0}", banana[i]);
            }           

        }
    }
}
