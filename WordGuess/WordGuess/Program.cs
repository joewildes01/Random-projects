using System;
using System.Linq;
using System.Collections.Generic;


namespace WordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rnd = new Random();

            int Guesses = 5;
            int WordLength;
            char[] Alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            int WordSelect = rnd.Next(1, 5);
            char[] word = { ' ' };
            bool Done = false;

            

            

            


            Console.WriteLine("How long do you want the word to be?");
            Console.WriteLine("1 - Three letter word");
            Console.WriteLine("2 - Four letter word");
            Console.WriteLine("3 - Five letter word");
            Console.WriteLine("4 - Six letter word");
            Console.WriteLine("5 - Seven letter word");
            int Option = int.Parse(Console.ReadLine());

            switch (Option)
            {
                case 1:
                    word = Dictionary.RandomThreeLetterWord[WordSelect].ToCharArray();
                    
                    break;
                case 2:
                    word = Dictionary.RandomFourLetterWord[WordSelect].ToCharArray();
                    
                    break;
                case 3:
                    word = Dictionary.RandomFiveLetterWord[WordSelect].ToCharArray();
                    
                    break;
                case 4:
                    word = Dictionary.RandomSixLetterWord[WordSelect].ToCharArray();
                    
                    break;
                case 5:
                    word = Dictionary.RandomSevenLetterWord[WordSelect].ToCharArray();
                    
                    break;

                default:
                    break;
            }
            

            int ToWin = word.Length;
            char[] ThreeWord = word;


            WordLength = word.Length;

            do
            {
                if (Guesses == 1 || ToWin == 1)
                {
                    Done = true;
                }

                Console.WriteLine("The length of the word is {0}", WordLength);
                Console.WriteLine("You have {0} Guesses left", Guesses);

                for (int i = 0; i < word.Length; i++)
                {
                    Console.Write(word[i]);

                }


                

                Console.WriteLine();
                Console.WriteLine("Please enter a letter - Avaliable letters:");




                for (int i = 0; i < Alphabet.Length; i++)
                {
                    Console.Write(Alphabet[i] + " ");

                }
                Console.WriteLine();
                Console.WriteLine();

                
                
                Console.WriteLine();
                char UserInput = Convert.ToChar(Console.ReadLine());




                if (word.Contains(UserInput))
                {
                    Console.WriteLine("Correct!");
                    Alphabet[Array.IndexOf(Alphabet, UserInput)] = ' ';
                    
                                     
                    ToWin--;

                }
                else
                {
                    Console.WriteLine("Incorrect");
                    Alphabet[Array.IndexOf(Alphabet, UserInput)] = ' ';

                    Guesses--;
                    
                }
                

            } while (Done == false);

           

            if (Guesses == 0)
            {
                Console.WriteLine("Sorry youre out of guesses");
                Console.WriteLine();
                Console.WriteLine("GAME OVER");
                Console.ReadLine();

            }
            if (ToWin == 0)
            {
                word.ToString();
                Console.WriteLine("Great! You won!");
                Console.WriteLine("The word was");
                for (int i = 0; i < word.Length; i++)
                {
                    Console.Write(word[i]);

                }
                Console.ReadLine();

            }

        }
    }
}
