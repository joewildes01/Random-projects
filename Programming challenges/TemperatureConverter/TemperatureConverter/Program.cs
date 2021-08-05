using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What unit do you want to convert to");
            Console.WriteLine("1 - Celcius");
            Console.WriteLine("2 - Fahrenheit");
            int Option = int.Parse(Console.ReadLine());

            switch (Option)
            {
                case 1:
                    goto celcius;
                case 2:
                    goto fahrenheit;
                default:
                    break;
            }

        fahrenheit:;

            Console.WriteLine("Please input your temperature in Celcius");

            int CelciusInput = int.Parse(Console.ReadLine());

            int FahrenheitOutput = (CelciusInput * 9 / 5) + 32;

            Console.WriteLine("You entered {0}F. Your converted temp is {1}C",CelciusInput, FahrenheitOutput);

            Environment.Exit(-1);


        celcius:;


            Console.WriteLine("Please input your temperature in Fahrenheit");

            int FahrenheitInput = int.Parse(Console.ReadLine());

            int CelciusOutput = (FahrenheitInput - 32) * 5 / 9;

            Console.WriteLine("You entered {0}F. Your converted temp is {1}C", FahrenheitInput, CelciusOutput);

            Environment.Exit(-1);





        }
    }
}
