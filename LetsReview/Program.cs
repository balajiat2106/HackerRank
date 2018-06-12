using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsReview
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordCount = Convert.ToInt32(Console.ReadLine());
            string[] word = new string[wordCount];
            char[] letters=new char[wordCount];
            string evenLetters=string.Empty;
            string oddLetters=string.Empty;
            for (int i = 0; i < wordCount; i++)
            {
                word[i] = Console.ReadLine();
            }
            for (int i = 0; i < wordCount; i++)
            {
                letters = word[i].ToCharArray();
                for (int j = 0; j < letters.Length; j++)
                {
                    if (j%2 == 0)
                    {
                        evenLetters = evenLetters + letters[j];
                    }
                    else
                    {
                        oddLetters = oddLetters + letters[j];
                    }
                }
                Console.WriteLine(evenLetters + "  " + oddLetters);
                evenLetters = string.Empty;
                oddLetters = string.Empty;
            }
            
            Console.ReadLine();
        }
    }
}
