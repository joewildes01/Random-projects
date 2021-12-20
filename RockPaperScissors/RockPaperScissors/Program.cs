using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            

            
            
            bool KeepPlaying = true;
            int OpponentScore = 0;
            int UserScore = 0;



            while (KeepPlaying == true)
            {
                Random rnd = new Random();
                
                string[] Opponent = { "Rock", "Paper", "Scissors" };
                
                Console.WriteLine("Rock, Paper or Scissors?");
                Console.WriteLine("1 - Rock");
                Console.WriteLine("2 - Paper");
                Console.WriteLine("3 - Scissors");
                int userChoice = int.Parse(Console.ReadLine());
                string userDecision = "";

                switch (userChoice)
                {
                    case 1:
                        userDecision = "Rock";
                        Console.WriteLine("You played Rock");
                        break;
                    case 2:
                        userDecision = "Paper";
                        Console.WriteLine("You played Paper");
                        break;
                    case 3:
                        userDecision = "Scissors";
                        Console.WriteLine("You played Scissors");
                        break;

                    default:
                        break;
                }
                

                int OpponentChoice = rnd.Next(0, Opponent.Length);

                Console.WriteLine("Opponent played {0}", Opponent[OpponentChoice]);

                if (Opponent[OpponentChoice] == userDecision)
                {
                    Console.WriteLine("Its a draw!");

                }
                if (Opponent[OpponentChoice] == "Paper" && userDecision == "Rock" || userDecision == "Paper" && Opponent[OpponentChoice] == "Rock")
                {
                    Console.WriteLine("Paper beats rock!");
                    if (Opponent[OpponentChoice] == "Paper")
                    {
                        OpponentScore++;
                    }
                    if (userDecision == "Paper")
                    {
                        UserScore++;

                    }

                }
                if (userDecision == "Paper" && Opponent[OpponentChoice] == "Scissors" || Opponent[OpponentChoice] == "Paper" && userDecision == "Scissors")
                {
                    Console.WriteLine("Scissors beats paper!");
                    if (Opponent[OpponentChoice] == "Scissors")
                    {
                        OpponentScore++;
                    }
                    if (userDecision == "Scissors")
                    {
                        UserScore++;

                    }

                }
                if (userDecision == "Scissors" && Opponent[OpponentChoice] == "Rock" || Opponent[OpponentChoice] == "Scissors" && userDecision == "Rock")
                {
                    Console.WriteLine("Rock beats Scissors!");
                    if (Opponent[OpponentChoice] == "Rock")
                    {
                        
                        OpponentScore++;
                    }
                    if (userDecision == "Rock")
                    {
                        UserScore++;

                    }

                }
                Console.WriteLine("You {0} - Opponent {1}", UserScore, OpponentScore);

                Console.WriteLine("Keep Playing?");
                Console.WriteLine("1 - Yes/2 - No");
                int playing = int.Parse(Console.ReadLine());

                if (playing == 1)
                {
                    KeepPlaying = true;
                }
                if (playing == 2)
                {
                    KeepPlaying = false; 

                }

            }

            Console.WriteLine("Final Score");
            Console.WriteLine("You {0} - {1} Opponent",UserScore, OpponentScore);
            if (UserScore > OpponentScore)
            {
                Console.WriteLine("User Wins!");

            }
            if (OpponentScore > UserScore)
            {
                Console.WriteLine("Opponent Wins!");

            }
            Console.WriteLine("Thanks for playing");

            


        }
    }
}
