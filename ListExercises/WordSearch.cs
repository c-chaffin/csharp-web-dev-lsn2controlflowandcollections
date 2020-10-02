using System;
using System.Collections.Generic;
using System.Text;

namespace ListExercises
{
    public class WordSearch
    {
        public static string Search(List<string> list)
        {
            string foundWords = "";
            string input;
            int lengthOfWord;

            Console.WriteLine("Enter number of letters: ");
            input = Console.ReadLine();
            lengthOfWord = int.Parse(input);

            foreach (string word in list)
            {
                if (word.Length.Equals(lengthOfWord))
                {
                    foundWords += word;
                } 
            } return foundWords;
        }
    }
}
