using System;

internal class Result
{
    public static int divisibleSumPairs(int n, int k, List<int> ar)
    {
        int numOfPairs = 0;

        // iterate thrpugh the list 
        // i at the first index
        // j at the last index
        for (int i = 0, j = ar.Count - 1; i < ar.Count; i++)
        {
            // iterate through the j values to check the condition
            while (j > i)
            {                
                if ((ar[i] + ar[j]) % k == 0)
                {
                    numOfPairs++;
                }
                j--;
            }

            // start the loop at the next i++
            // and reset the j value to the last index
            j = ar.Count - 1;
        }

        return numOfPairs;
    }

    //*****************************************************************************************************************


    public static void Main(string[] args)
    {
        // Example 1
        {
            // arr = { 1, 2, 3, 4, 5, 6 }
            // n = 6
            // k = 5

            int elements = 6;
            int k = 5;
            List<int> arr = new List<int>(elements) { 1, 2, 3, 4, 5, 6 };

            Helper.DisplayExample(
                "arr = { 1, 2, 3, 4, 5, 6 }\n" +
                "n = 6\t\tk = 5\n",
                "3");
            Console.WriteLine(Result.divisibleSumPairs(elements, k, arr));
        }
        Console.WriteLine(new string('-', 100));



        // Example 2
        {
            // arr = { 1, 3, 2, 6, 1, 2 }
            // n = 6
            // k = 3

            int elements = 6;
            int k = 3;
            List<int> arr = new List<int>(elements) { 1, 3, 2, 6, 1, 2 };

            Helper.DisplayExample(
                "arr = { 1, 3, 2, 6, 1, 2 }\n" +
                "n = 6\t\tk = 3\n",
                "5");
            Console.WriteLine(Result.divisibleSumPairs(elements, k, arr));
        }
        Console.WriteLine(new string('-', 100));
    }
}