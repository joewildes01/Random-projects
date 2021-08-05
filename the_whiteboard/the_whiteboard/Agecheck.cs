using System;
namespace the_whiteboard
{
    public class Agecheck
    {
        public static void is18()
        {
            int BirthYear = int.Parse(Console.ReadLine());

            if (BirthYear >= 2003)
            {
                Console.WriteLine("Sorry, you are not old enough");
                

            }
            else
            {
                if (BirthYear > 60)
                {
                    Console.WriteLine("You qualify for our senior programme, You will be redirected shortly");
                }
                else
                {
                    Console.WriteLine("Thank you, you will now be redirected");
                    Environment.Exit(0);
                }
                
            }
           
        }

        
        
        
        
            
        
    }
}
