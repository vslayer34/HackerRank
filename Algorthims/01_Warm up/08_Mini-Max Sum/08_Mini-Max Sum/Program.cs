using System;

internal class Result
{
    public static void miniMaxSum(List<int> arr)
    {
        // two lists to contain least 4 and max 4 numbers
        List<long> maxNums = new List<long>();
        List<long> minNums = new List<long>();

        // sort the list
        arr.Sort();

        // add the first 4 numbers to the minimum
        // add the last 4 numbers to the last
        for (int i = 0, j = arr.Count - 1; i < 4; i++, j--)
        {
            minNums.Add(arr[i]);
            maxNums.Add(arr[j]);
        }

        // Write the sum of the two 4 least and max to the screen
        // format: sum of 4 least + " " + sum of 4 max
        Console.WriteLine($"{minNums.Sum()} {maxNums.Sum()}");
    }


    public static void Main(string[] args)
    {
        // Example 1
        {
            List<int> arr = new List<int>() { 1, 3, 5, 7, 9 };

            Helper.DisplayExample("arr = { 1, 3, 5, 7, 9 }\n", "16 24");
            Result.miniMaxSum(arr);
        }
        Console.WriteLine(new string('-', 100));



        // Example 2
        {
            List<int> arr = new List<int>() { 1, 2, 3, 4, 5 };

            Helper.DisplayExample("arr = { 1, 2, 3, 4, 5 }\n", "10 14");
            Result.miniMaxSum(arr);
        }
        Console.WriteLine(new string('-', 100));


        
        // Example 3
        {
            List<int> arr = new List<int>() { 256741038, 623958417, 467905213, 714532089, 938071625 };

            Helper.DisplayExample("arr = { 256741038 , 623958417, 467905213 , 714532089, 938071625 }\n",
                                  "2063136757 2744467344");
            Result.miniMaxSum(arr);
        }
        Console.WriteLine(new string('-', 100));
    }
}