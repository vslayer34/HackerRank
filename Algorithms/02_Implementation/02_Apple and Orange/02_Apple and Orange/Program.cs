using System;
using System.Threading.Channels;

internal class Result
{
    public static void countApplesAndOranges(int houseLeft, int houseRight, int appleTree, int orangeTree, List<int> apples, List<int> oranges)
    {
        // iterator
        int i = 0;

        // number of ornanges and apples fell on the house
        int applesNumber = 0;
        int orangesNumber = 0;

        // iterate through the two lists
        // and add the tree point to the fruits
        // check if the fruit fell on the house
        foreach (int apple in apples)
        {
            if (apple + appleTree >= houseLeft &&  apple + appleTree <= houseRight)
            {
                applesNumber++;
            }
        }

        foreach (int orange in oranges)
        {
            if (orange + orangeTree >= houseLeft && orange + orangeTree <= houseRight)
            {
                orangesNumber++;
            }
        }

        Console.WriteLine(applesNumber.ToString() + '\n' + orangesNumber.ToString());
    }

    public static void Main(string[] args)
    {
        // Example 1
        {
            // House Left = 7, House Right = 10
            int houseLeftPoint = 7;
            int houseRightPoint = 10;

            // apple tree = 4, orange tree = 12
            int appleTree = 4;
            int orangeTree = 12;

            // 3 apples [ 2, 3, -4 ]
            // 3 oranges [ 3, -2, -4 ]
            List<int> apples = new List<int>() { 2, 3, -4 };
            List<int> oranges = new List<int>() { 3, -2, -4 };

            Helper.DisplayExample(
                "House Left = 7, House Right = 10\n" +
                "apple tree = 4, orange tree = 12\n" +
                "3 apples [ 2, 3, -4 ]\n" +
                "3 oranges [ 3, -2, -4 ]\n",
                "1\n2");
            Result.countApplesAndOranges(houseLeftPoint, houseRightPoint, appleTree, orangeTree, apples, oranges);
        }
        Console.WriteLine(new string('-', 100));



        // Example 2
        {
            // House Left = 7, House Right = 11
            int houseLeftPoint = 7;
            int houseRightPoint = 11;

            // apple tree = 5, orange tree = 15
            int appleTree = 5;
            int orangeTree = 15;

            // 3 apples [ -2, 2, 1 ]
            // 2 oranges [ 5, -6 ]
            List<int> apples = new List<int>() { -2, 2, 1 };
            List<int> oranges = new List<int>() { 5, -6 };

            Helper.DisplayExample(
                "House Left = 7, House Right = 11\n" +
                "apple tree = 5, orange tree = 15\n" +
                "3 apples [ -2, 2, 1 ]\n" +
                "3 oranges [ 5, -6, ]\n",
                "1\n1");
            Result.countApplesAndOranges(houseLeftPoint, houseRightPoint, appleTree, orangeTree, apples, oranges);
        }
        Console.WriteLine(new string('-', 100));
    }
}