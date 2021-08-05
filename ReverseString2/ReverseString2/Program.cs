using System;

namespace ReverseString2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tobeReversed = "Alex is a fag";

            char[] reverse = tobeReversed.ToCharArray();
            

            for (int i = reverse.Length - 1; i > -1; i--)
            {
                Console.Write("{0} ", reverse[i]);
            }
        }
    }
}
