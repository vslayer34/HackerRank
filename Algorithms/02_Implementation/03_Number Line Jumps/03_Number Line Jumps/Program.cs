using System;

internal class Result
{
    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
        if (v1 == v2)
        {
            return "NO";
        }
        else if ((x2 - x1) % (v1 - v2) != 0)
        {
            return "NO";
        }
        else if ((x2 > x1 && v2 > v1) || (x1 > x2 && v1 > v2))
        {
            return "NO";
        }

        return "YES";
    }

    //*********************************************************************************************

    public static void Main(string[] args)
    {
        // Example 1
        {
            // x1 = 2, v1 = 1
            // x2 = 1, v2 = 2
            // output: YES

            int x1 = 2;
            int v1 = 1;
            int x2 = 1;
            int v2 = 2;

            Helper.DisplayExample(
                "x1 = 2, v1 = 1\n" +
                "x2 = 1, v2 = 2\n",
                "YES");
            Console.WriteLine(Result.kangaroo(x1, v1, x2, v2));
        }
        Console.WriteLine(new string('-', 100));



        // Example 2
        {
            // x1 = 0, v1 = 3
            // x2 = 4, v2 = 2
            // output: YES

            int x1 = 0;
            int v1 = 3;
            int x2 = 4;
            int v2 = 2;

            Helper.DisplayExample(
                "x1 = 0, v1 = 3\n" +
                "x2 = 4, v2 = 2\n",
                "YES");
            Console.WriteLine(Result.kangaroo(x1, v1, x2, v2));
        }
        Console.WriteLine(new string('-', 100));



        // Example 3
        {
            // x1 = 0, v1 = 2
            // x2 = 5, v2 = 3
            // output: NO

            int x1 = 0;
            int v1 = 2;
            int x2 = 5;
            int v2 = 3;

            Helper.DisplayExample(
                "x1 = 0, v1 = 2\n" +
                "x2 = 5, v2 = 3\n",
                "NO");
            Console.WriteLine(Result.kangaroo(x1, v1, x2, v2));
        }
        Console.WriteLine(new string('-', 100));



        // Test Case 2
        {
            // x1 = 14, v1 = 4
            // x2 = 98, v2 = 2
            // output: YES

            int x1 = 14;
            int v1 = 4;
            int x2 = 98;
            int v2 = 2;

            Helper.DisplayExample(
                "x1 = 14, v1 = 4\n" +
                "x2 = 98, v2 = 2\n",
                "YES");
            Console.WriteLine(Result.kangaroo(x1, v1, x2, v2));
        }
        Console.WriteLine(new string('-', 100));



        // Test Case 10
        {
            // x1 = 43, v1 = 2
            // x2 = 70, v2 = 2
            // output: NO

            int x1 = 43;
            int v1 = 2;
            int x2 = 70;
            int v2 = 2;

            Helper.DisplayExample(
                "x1 = 43, v1 = 2\n" +
                "x2 = 70, v2 = 2\n",
                "NO");
            Console.WriteLine(Result.kangaroo(x1, v1, x2, v2));
        }
        Console.WriteLine(new string('-', 100));
    }
}