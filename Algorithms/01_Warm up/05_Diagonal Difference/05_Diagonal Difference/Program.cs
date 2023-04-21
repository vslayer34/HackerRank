using System;
using System.ComponentModel.Design;

internal class Result
{
    public static int diagonalDifference(List<List<int>> arr)
    {
        // two sums for each diagonal
        int sum1 = 0;
        int sum2 = 0;

        // index to iterate through each list
        int leftToRightIndex = 0;                   // starts from the bigining
        int rightToLeftIndex = arr.Count - 1;       // starts from the end

        for (int i = 0; i < arr.Count; i++)
        {
            sum1 += arr[i][leftToRightIndex];
            sum2 += arr[i][rightToLeftIndex];
            leftToRightIndex++;
            rightToLeftIndex--;
        }
        
        return Math.Abs(sum1 - sum2);
    }


    public static void Main(string[] args)
    {
        // Example 1
        {
            // input =
            // 11   2     4
            // 4    5     6
            // 10   8    -12

            // output = 15

            List<List<int>> input = new List<List<int>>()
            {
                new List<int>() { 11, 2, 4 },
                new List<int>() { 4, 5, 6 },
                new List<int>() { 10, 8, -12 }
            };

            Helper.DisplayExample(
                "11   2     4\n" +
                "4    5     6\n" +
                "10   8    -12\n",
                output: "15");
            Console.WriteLine(Result.diagonalDifference(input));
        }
        Console.WriteLine(new string('-', 100));
    }
}