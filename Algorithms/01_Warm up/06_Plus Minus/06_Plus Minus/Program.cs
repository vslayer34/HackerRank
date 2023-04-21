using System;

internal class Result
{
    public static void plusMinus(List<int> arr)
    {
        // counter for the 3 states
        int positiveNumbers = 0;
        int negativeNumbers = 0;
        int zeros = 0;

        // iratate through the list and add numbers to each counter
        foreach (int num in arr)
        {
            if (num > 0)
                positiveNumbers++;

            else if (num < 0)
                negativeNumbers++;

            else
                zeros++;
        }

        float arrCount = arr.Count;

        Console.WriteLine($"{(positiveNumbers / arrCount).ToString("F6")}\n" +
                          $"{(negativeNumbers / arrCount).ToString("F6")}\n" +
                          $"{(zeros / arrCount).ToString("F6")}");
    }


    public static void Main(string[] args)
    {
        // Example 1
        {
            // array size: 6
            // array elements: { -4, 3, -9, 0, 4, 1 }
            List<int> list = new List<int>() { -4, 3, -9, 0, 4, 1 };

            // output =
            // 0.500000
            // 0.333333
            // 0.166667

            Helper.DisplayExample("array size: 6\n" +
                "array elements: { -4, 3, -9, 0, 4, 1 }",
                "0.500000\n\t\t0.333333\n\t\t0.166667\n");

            Result.plusMinus(list);
        }
        Console.WriteLine(new string('-', 100));



        // Example 2
        {
            // array size: 8
            // array elements: { 1, 2, 3, -1, -2, -3, 0, 0 }
            List<int> list = new List<int>() { 1, 2, 3, -1, -2, -3, 0, 0 };

            // output =
            // 0.375000
            // 0.375000
            // 0.250000

            Helper.DisplayExample("array size: 8\n" +
                "array elements: { 1, 2, 3, -1, -2, -3, 0, 0 }",
                "0.375000\n\t\t0.375000\n\t\t0.250000\n");

            Result.plusMinus(list);
        }
        Console.WriteLine(new string('-', 100));
    }
}