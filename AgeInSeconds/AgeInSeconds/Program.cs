using System;

namespace AgeInSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int UserAge = int.Parse(Console.ReadLine());

            int result = (UserAge * 31449600); //288 weeks //2016 days //48384 hours //2903040 minutes
            //174182400 seconds

            Console.WriteLine("Your age in seconds is {0} Seconds", result);

            int leap = (UserAge / 4);

            int LeapYear = (leap * 86400);

            int NewResult = LeapYear + result;

            Console.WriteLine("Your age in seconds including leap years is {0}", NewResult);
        }
    }
}
