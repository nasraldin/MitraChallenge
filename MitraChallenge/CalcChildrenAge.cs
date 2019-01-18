using System.Collections.Generic;

namespace MitraChallenge
{
    public class CalcChildrenAge
    {
        /// <summary>
        /// return a new array with the time needed for each children to be half of their father’s age.
        /// </summary>
        /// <param name="childrenArray"></param>
        /// <param name="fatherArray"></param>
        /// <returns></returns>
        public static List<int> GetChildrenAgeNeeded(List<int> childrenArray, List<int> fatherArray)
        {
            // if count is greater/lees than 2, can't calc 
            if (childrenArray.Count == 0 || fatherArray.Count == 0
                || childrenArray.Count > 2 || fatherArray.Count > 2
                || childrenArray.Count < 2 || fatherArray.Count < 2)
                return null;

            // will contain needed age result
            List<int> neededArray = new List<int>();

            foreach (var fatherAge in fatherArray)
            {
                // get half of father age
                int halfFatherAge = fatherAge / 2;

                foreach (var childrenAge in childrenArray)
                {
                    // get children age needed to be half of the father
                    int ageNeeded = halfFatherAge - childrenAge;

                    // added age needed to array
                    neededArray.Add(ageNeeded);

                    // remove calc element from array 
                    childrenArray.Remove(childrenAge);
                    break;
                }
            }

            return neededArray;
        }
    }
}
