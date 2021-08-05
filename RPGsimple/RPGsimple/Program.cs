using System;

namespace RPGsimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, if no text is appearing press enter to continue");
            Console.ReadLine();

            Console.WriteLine("Ah Hero... You're finally awake..");

            Console.WriteLine("Tell me a little something about yourself..");
            
        

            Hero hero1 = new Hero("NULL", 0, 0, 0, "NULL", 100);


            bool Ready = false;
            

           
            Console.WriteLine("Are you a man or a woman?");
            Console.WriteLine("1 - Man / 2 - Woman");
            int Option1 = int.Parse(Console.ReadLine());
            if (Option1 == 1)
            {
                hero1.Gender = "Male";

            }
            if (Option1 == 2)
            {
                hero1.Gender = "Female";

            }

            Console.WriteLine("Ah a {0} are we!", hero1.Gender);

            

            do
            {
                
                Console.WriteLine("Whats your name Hero?");
                hero1.Name = Console.ReadLine();
                

                Console.WriteLine("Oh so youre name is {0}", hero1.Name);

                Console.WriteLine("1 - Yes / 2 - No");
                Option1 = int.Parse(Console.ReadLine());


                if (Option1 == 1)
                {
                    Ready = true;
                }
                else
                {
                    Ready = false;
                }


            } while (Ready == false);

            Console.WriteLine("Great {0}, lets move on..", hero1.Name);
            Console.ReadLine();
            Ready = false;
            string ClassChoice = "Null";
            do
            {
                Console.WriteLine("Tell me, what kind of hero are you?");
                Console.WriteLine("1 - Warrior");
                Console.WriteLine("2 - Mage");
                Console.WriteLine("3 - Cleric");
                int Option2 = int.Parse(Console.ReadLine());
                


                if (Option2 == 1)
                {
                    ClassChoice = "Warrior";
                    hero1.Attack = 13;
                    hero1.Defence = 11;
                    hero1.Magic = 3;

                }
                if (Option2 == 2)
                {
                    ClassChoice = "Mage";
                    hero1.Attack = 11;
                    hero1.Defence = 4;
                    hero1.Magic = 12;
                }
                if (Option2 == 3)
                {
                    ClassChoice = "Cleric";
                    hero1.Attack = 5;
                    hero1.Defence = 10;
                    hero1.Magic = 11;

                }
                Console.WriteLine("Ah youve chosen {0}", ClassChoice);

                Console.WriteLine("Your stats are Attack = {0}, Defence = {1}, Magic = {2}", hero1.Attack, hero1.Defence, hero1.Magic);
                Console.WriteLine("Is your selection correct?");
                Console.WriteLine("1 - Yes / 2 - No");
                int Option3 = int.Parse(Console.ReadLine());
                if (Option3 == 1)
                {
                    Ready = true;

                }
                if (Option2 == 2)
                {
                    Ready = false;

                }
                
            } while (Ready == false);

            Console.WriteLine("So in conclusion you are.. {0}, a {1}, who is a {2}.. Great", hero1.Name, hero1.Gender, ClassChoice);
            Console.WriteLine("{0}, Your great story is about to unfold.. Lets jump right in, Ill be waiting for you", hero1.Name);


            Console.WriteLine("Zzz...");

            Console.WriteLine("Tomorrow you set out for the great city of Lanthric, you dream of defending the king and becoming a hero");

            Console.ReadLine();
            Enemy DreamEnemy = new Enemy("Assassin", 4, 6, 2, 1, 80);

            Battle.Fight(hero1, DreamEnemy);


            

            

            
        }
    }
}
