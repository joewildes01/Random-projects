using System;

namespace BasicEncyption
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a password");
            string password = Console.ReadLine();

            char[] apple = password.ToCharArray();

            for (int i = 0; i < apple.Length; i++)
            {
                Console.Write(apple[i] + " ");

            }
        }
    }
}
