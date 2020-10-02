using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 5, 8, 10, 14, 20, 54, 78, 76, 100 };
            Console.WriteLine(Sum.SumOfList(numbers));

            List<string> words = new List<string> { "cat", "dog", "stadium", "books", "tool", "magic", "milk" };
            Console.WriteLine(WordSearch.Search(words));
        }

    }
}
