using System;

internal class Result
{
    public static int getTotalX(List<int> a, List<int> b)
    {
        int maxInListA = a.Max();
        int minInListB = b.Min();
        
        // list of numbers between list a and list b
        List<int> betweenAandB = new List<int>();
        
        for (int i = maxInListA; i <= minInListB; i++)
        {
            // add the number
            betweenAandB.Add(i);
            
            // check if it's a factor to number of list a
            // and remove from the list otherwise
            foreach (int num in a)
            {
                if (i % num != 0)
                {
                    betweenAandB.Remove(i);
                }
            }

            // check if it's a factor to number of list b
            // and remove from the list otherwise
            foreach (int num in b)
            {
                if (num % i != 0)
                {
                    betweenAandB.Remove(i);
                }
            }
        }

        return betweenAandB.Count;
    }

    public static void Main(string[] args)
    {
        // Example 1
        {
            // input1: { 2, 6 }
            // input2: { 24, 36 }

            List<int> a = new List<int>(2) { 2, 6 };
            List<int> b = new List<int>(2) { 24, 36 };

            // output: 2

            Helper.DisplayExample(
                "a = { 2, 6 }\n" +
                "b = { 24, 36 }\n",
                "2");

            Console.WriteLine(getTotalX(a, b));
        }
        Console.WriteLine(new string('-', 100));


        // Example 2
        {
            // input1: { 2, 4 }
            // input2: { 16, 32, 96 }

            List<int> a = new List<int>(2) { 2, 4 };
            List<int> b = new List<int>(3) { 16, 32, 96 };

            // output: 3

            Helper.DisplayExample(
                "a = { 2, 4 }\n" +
                "b = { 16, 32, 96 }\n",
                "3");

            Console.WriteLine(getTotalX(a, b));
        }
        Console.WriteLine(new string('-', 100));
    }
}