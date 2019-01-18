using System;

namespace MitraChallenge
{
    /// <summary>
    /// Find the highest product between 3 of those numbers in an array of integers.
    /// </summary>
    public class HighestProduct
    {
        /// <summary>
        /// a method that, given a list of integers, returns the highest product between 3 of those numbers.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int GetHighestProduct(int[] array, int n)
        {
            // if size is less than 3, no triplet exists 
            if (n < 3)
                return -1;

            #region FindByForloop
            // find number by for loop style

            // will contain highest product 
            int highestProduct = int.MinValue;

            for (int i = 0; i < n - 2; i++)
                for (int j = i + 1; j < n - 1; j++)
                    for (int k = j + 1; k < n; k++)
                        highestProduct = Math.Max(highestProduct,
                                  array[i] * array[j] * array[k]);

            return highestProduct;

            #endregion

            #region FindBySortingAlgorithm
            // Sort the array using some efficient in-place sorting algorithm in ascending order.
            // Return the highest of product of last three elements of the array and product of first two elements and last element.

            // Sort the array in ascending order  
            //Array.Sort(array);

            //// Return the highest of product of last three  
            //// elements and product of first two elements and last element
            //return Math.Max(array[0] * array[1] * array[n - 1],
            //        array[n - 1] * array[n - 2] * array[n - 3]);

            #endregion
        }
    }
}
