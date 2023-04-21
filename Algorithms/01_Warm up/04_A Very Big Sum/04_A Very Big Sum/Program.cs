using System;

internal class Result
{
    public static long aVeryBigSum(List<long> numsList)
    {
        long sum = 0;

        foreach (long num in numsList)
        {
            sum += num;
        }
        return sum;
    }

    public static void Main(string[] args)
    {
        // Example 1
        {
            // number of elements 5
            // elements: 1000000001 1000000002 1000000003 1000000004 1000000005
            // output = 5000000015

            List<long> nums = new List<long>() { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };

            Helper.DisplayExample("elements: 1000000001 1000000002 1000000003 1000000004 1000000005", "5000000015");
            Console.WriteLine(Result.aVeryBigSum(nums));
        }
        Console.WriteLine(new string('-', 100));
    }
}