using System;

internal class Result
{
    public static void staircase(int size)
    {
        int whiteSpaces = size - 1;
        for (int i = 1; i <= size; i++)
        {
            Console.Write(new string(' ', whiteSpaces));
            Console.WriteLine(new string('#', i));
            whiteSpaces--;
        }
    }

    public static void Main(string[] args)
    {
        // Example 1
        {
            // input = 6
            int input = 6;

            Helper.DisplayExample("Staircase size: 6",
                "\n     #\n" +
                "    ##\n" +
                "   ###\n" +
                "  ####\n" +
                " #####\n" +
                "######\n");

            Console.WriteLine();
            Result.staircase(input);
        }
        Console.WriteLine(new string('-', 100));
    }
}