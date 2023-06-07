using System;

internal class Result
{
    public static int sockMerchant(int n, List<int> ar)
    {
        return 0;
    }

    public static void Main(string[] args)
    {
        // Example 1
        {
            // number of socks = 7
            // list of socks: { 1, 2, 1, 2, 1, 3, 2 }
            // output: 2

            int numOfSocks = 7;
            List<int> listOfSocks = new List<int>(numOfSocks) { 1, 2, 1, 2, 1, 3, 2 };

            Helper.DisplayExample(
                $"Number of socks: {numOfSocks}\n" +
                "List of Socks: { 1, 2, 1, 2, 1, 3, 2 }\n",
                2.ToString());

            Console.WriteLine(sockMerchant(numOfSocks, listOfSocks));
        }
        Console.WriteLine(new string('-', 100));



        // Example 2
        {
            // number of socks = 9
            // list of socks: { 10, 20, 20, 10, 10, 30, 50, 10, 20 }
            // output: 3

            int numOfSocks = 9;
            List<int> listOfSocks = new List<int>(numOfSocks) { 10, 20, 20, 10, 10, 30, 50, 10, 20 };

            Helper.DisplayExample(
                $"Number of socks: {numOfSocks}\n" +
                "List of Socks: { 10, 20, 20, 10, 10, 30, 50, 10, 20 }\n",
                3.ToString());

            Console.WriteLine(sockMerchant(numOfSocks, listOfSocks));
        }
        Console.WriteLine(new string('-', 100));
    }
}