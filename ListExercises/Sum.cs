using System;
using System.Collections.Generic;
using System.Text;

namespace ListExercises
{
    public class Sum
    {
        public static int SumOfList(List<int> list)
        {
            int sum = 0;
            foreach (int num in list)
            {
                if (num % 2 == 0)
                {
                   sum += num;
                }
            } return sum;
        }
    }
}
