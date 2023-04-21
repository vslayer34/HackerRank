using System;

internal class Result
{
    public static int birthdayCakeCandles(List<int> candles)
    {
        int numOfTallestCandles = 0;
        int tallestCandle = candles.Max();

        foreach (int candle in candles)
        {
            if (candle >= tallestCandle)
                numOfTallestCandles++;
        }

        return numOfTallestCandles;
    }

    public static void Main(string[] args)
    {
        // Example 1
        {
            // Input = {3, 2, 1, 3}
            // output = 2
            List<int> inputs = new List<int>() { 3, 2, 1, 3 };

            Helper.DisplayExample("Input = {3, 2, 1, 3}\n", "2");
            Console.WriteLine(Result.birthdayCakeCandles(inputs));
        }
        Console.WriteLine(new string('-', 100));
    }
}