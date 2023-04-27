using System;

internal class Result
{
    public static int birthday(List<int> choclateBar, int digitSum, int consecutiveSquares)
    {
        int numberOfSections = 0;

        for (int i = 0; i < choclateBar.Count; i++)
        {
            // the square we are at
            int atWhichSquare = 0;
            int sum = 0;

            // check the consecutiveSquares
            while (atWhichSquare < consecutiveSquares)
            {
                // break of the while loop of the next indexs is more than the list count
                if ((atWhichSquare + i) > choclateBar.Count - 1)
                {
                    break;
                }

                sum += choclateBar[i + atWhichSquare];
                atWhichSquare++;
            }

            if (sum == digitSum)
            {
                numberOfSections++;
            }
        }
        
        return numberOfSections;
    }

    public static void Main(string[] args)
    {
        // Example 1
        {
            // list size: 5
            // list: { 1, 2, 1, 3, 2 }
            // sum = 3, number of consecutive squares = 2
            // output: 2

            List<int> choclateBar = new List<int>() { 1, 2, 1, 3, 2 };
            int sum = 3;
            int consecutiveSquares = 2;

            Helper.DisplayExample(
                "list size: 5\n" +
                "list: { 1, 2, 1, 3, 2 }\n" +
                "sum = 3, number of consecutive squares = 2\n",
                "2");
            Console.WriteLine(Result.birthday(choclateBar, sum, consecutiveSquares));
        }
        Console.WriteLine(new string('-', 100));



        // Example 2
        {
            // list size: 6
            // list: { 1, 1, 1, 1, 1, 1 }
            // sum = 3, number of consecutive squares = 2
            // output: 0

            List<int> choclateBar = new List<int>() { 1, 1, 1, 1, 1, 1 };
            int sum = 3;
            int consecutiveSquares = 2;

            Helper.DisplayExample(
                "list size: 6\n" +
                "list: { 1, 1, 1, 1, 1, 1 }\n" +
                "sum = 3, number of consecutive squares = 2\n",
                "0");
            Console.WriteLine(Result.birthday(choclateBar, sum, consecutiveSquares));
        }
        Console.WriteLine(new string('-', 100));



        // Example 3
        {
            // list size: 1
            // list: { 4 }
            // sum = 4, number of consecutive squares = 1
            // output: 1

            List<int> choclateBar = new List<int>() { 4 };
            int sum = 4;
            int consecutiveSquares = 1;

            Helper.DisplayExample(
                "list size: 1\n" +
                "list: { 4 }\n" +
                "sum = 4, number of consecutive squares = 1\n",
                "1");
            Console.WriteLine(Result.birthday(choclateBar, sum, consecutiveSquares));
        }
        Console.WriteLine(new string('-', 100));
    }
}