using System;
using System.Collections.Generic;

namespace MitraChallenge
{
    /**
     * 1. Create a method that, given a list of integers, returns the highest product between 3 of those numbers. Example: [1, 10, 2, 6, 5, 3] = 300 
     * 
     * 2. Alice is 12 and her father is 36. After 12 years her age will be half of her father’s (24, 48). Her brother Tom is 14, it needs him 8 years for his age to be half of his fathers (22, 44). You have two arrays with the same lenght the first one has the ages of the children and the second has the ages of their father’s, return a new array with the time needed for each children to be half of their father’s age. Example: input: [12, 14], [44,44] => output [12, 8]
     * 
     * 3. You have an array of integers greater than 10. For each integer you will find the sum of all its digits. If the sum is greater than 10 you will add the digits of the new number and so on until you have a number less than 10. Find the most frequent number of the new array. Example: input: [123, 125013, 30] => Output:3
    **/

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coding challenge from Mitra-Intelligence coding by Nasr Eldin");
            Console.WriteLine("Please choose one of the Methods List");
            Console.WriteLine("Get Highest Product Enter 1");
            Console.WriteLine("Get Children Age Needed Enter 2");
            Console.WriteLine("Get Children Age Needed Enter 3");

            try
            {
            GetChoose:
                Console.WriteLine("\n Enter your choose number or enter 0 to exit program: ");
                var value = Console.ReadLine();

                if (int.TryParse(value, out int chooseNumber) && chooseNumber >= 1 && chooseNumber <= 3)
                {
                    switch (chooseNumber)
                    {
                        case 1:
                            int[] array = { 1, 10, 2, 6, 5, 3 };
                            int n = array.Length;

                            int highestProduct = HighestProduct.GetHighestProduct(array, n);

                            if (highestProduct == -1)
                                Console.WriteLine("count cannot less than 3");
                            else
                                Console.WriteLine($"\n Product array is [{ string.Join(", ", array)}] and Highest product is {highestProduct}");
                            goto GetChoose;

                        case 2:
                            List<int> childrenArray = new List<int> { 12, 14 };
                            List<int> fatherArray = new List<int> { 44, 44 };

                            var printCh = $"\n Children array is [{ string.Join(", ", childrenArray)}]";

                            List<int> neededAgeOfEachChildren = CalcChildrenAge.GetChildrenAgeNeeded(childrenArray, fatherArray);

                            if (neededAgeOfEachChildren == null)
                                Console.WriteLine("Array count not equal 2 element");
                            else
                                Console.WriteLine($"{printCh} and Father array is [{ string.Join(", ", fatherArray)}], \n Age needed for each children to be half of their father’s is [{string.Join(",", neededAgeOfEachChildren)}]");
                            goto GetChoose;

                        case 3:
                            int[] arrayOfNumber = { 123, 125013, 30 };

                            var result = MostFrequentNumber.FindMostFrequent(arrayOfNumber, arrayOfNumber.Length);

                            Console.WriteLine($"\n Array is [{ string.Join(", ", arrayOfNumber)}], most frequent number is: {result}");
                            goto GetChoose;
                    }
                }
                else
                {
                    if (value == "0")
                    {
                        return;
                    }

                    Console.WriteLine("Please Enter Valid Number!");
                    goto GetChoose;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("App Exception: ", ex.Message);
            }
        }
    }
}
