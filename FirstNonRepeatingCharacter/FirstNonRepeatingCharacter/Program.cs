using System;

namespace FirstNonRepeatingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string caseOne = "aaabcccdeeef";
            
            char[] tochar = caseOne.ToCharArray();

            for (int i = 0; i < tochar.Length; i++)
            {
                bool isSame = false;
                for (int j = 0; i < tochar.Length; i++)
                {
                    if (tochar[i] == tochar[j] && i != j)
                    {
                        isSame = true;
                        break;
                    }
                }
                if (!isSame)
                {
                    Console.WriteLine(tochar[i]);
                }
            }

         

            
           
        }
    }
}
