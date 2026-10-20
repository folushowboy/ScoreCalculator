using System;
using System.Collections.Generic;
using System.Text;

namespace ScoreCalculator
{
    public class CalculateScore
    {
        public static int Score(int[] numbers)
        {
            int total = 0;

            //Loops throught each number in the array of numbers 
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    // 1 is added for even numbers
                    total++;
                }
                else
                {
                    // 3 is added for odd numbers
                    total += 3;
                }
                if (num == 8)
                {
                    // 5 is added for the number 8 
                    // since 8 is an even number, the total will be equal 6
                    total += 5;
                }
            }

            return total;
        }



    }
}
