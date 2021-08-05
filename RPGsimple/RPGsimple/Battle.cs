using System;
using System.Collections.Generic;
using System.Linq;

namespace RPGsimple
{
    public static class Battle
    {
       

        public static void Fight(Hero hero, Enemy enemy)
        {

            var FightLines = new List<string> { "You swing your weapon wildly!", "You achieve a well placed blow!", "A good cleave to the enemy" };
            var random = new Random();
            int index = random.Next(FightLines.Count);
            var HitChance = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int Index2 = random.Next(HitChance.Count);
                       

            do
            {
                Console.WriteLine("What will you do?");
                Console.WriteLine("1 - Melee Attack");
                Console.WriteLine("2 - Magic Attack");
                Console.WriteLine("3 - Defend");
                Console.WriteLine("4 - Heal");
                int Choice = int.Parse(Console.ReadLine());
                if (Choice == 1)
                {
                    if (new[] {4, 5, 6, 7, 8, 9, 10 }.Contains(Index2)) 
                    {
                        Console.WriteLine(index);

                        enemy.HP -= hero.Attack;

                        Console.WriteLine("You hit the enemy, they have {0}HP remaining", enemy.HP);
                        

                    }
                    if (new[] {1, 2, 3}.Contains(index))
                    {
                        Console.WriteLine("Your attack missed");
                        Console.WriteLine("The enemy has {0}HP remaining", enemy.HP);


                    }

                }
                if (Choice == 2)
                {

                }
                if (Choice == 3)
                {

                }
                if (Choice == 4)
                {

                }


            } while (hero.HP > 0 || enemy.HP > 0);


            
            

        }
    }
}
