using System;
using System.Collections.Generic;

namespace MitraChallenge
{
    public class MostFrequentNumber
    {
        public static int FindMostFrequent(int[] arrayNumber, int n)
        {
            // will contain new array of result
            List<int> newArray = new List<int>();

            // loop for array number and sum digits
            foreach (var item in arrayNumber)
            {
                // For each integer find the sum of all its digits
                int result = SumDigits(item);

                // add result to new array
                newArray.Add(result);
            }

            // Sort the array 
            arrayNumber = newArray.ToArray();
            Array.Sort(arrayNumber);

            // find the max frequency using linear traversal 
            int max_count = 1, res = newArray[0];
            int curr_count = 1;

            for (int i = 1; i < n; i++)
            {
                if (newArray[i] == newArray[i - 1])
                    curr_count++;
                else
                {
                    if (curr_count > max_count)
                    {
                        max_count = curr_count;
                        res = newArray[i - 1];
                    }
                    curr_count = 1;
                }
            }

            // If last element is most frequent 
            if (curr_count > max_count)
            {
                max_count = curr_count;
                res = newArray[n - 1];
            }

            return res;
        }

        /// <summary>
        /// find the sum of all its digits the sum is not less than or equal to 9  
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int SumDigits(int n)
        {
            int sum = 0;

            // Loop to do sum while sum is not less than or equal to 9
            // If the sum is greater than 10 you will add the digits of the new number and so on until you have a number less than 10
            while (n > 0 || sum > 9)
            {
                if (n == 0)
                {
                    n = sum;
                    sum = 0;
                }
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
    }
}
