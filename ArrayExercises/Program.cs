using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 1, 2, 3, 5, 8 };

            for (int i = 0; i < 6; i += 2)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
