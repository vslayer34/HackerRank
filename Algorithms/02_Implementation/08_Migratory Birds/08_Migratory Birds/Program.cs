using System;

internal class Result
{
    public static int migratoryBirds(List<int> arr)
    {
        // sort array
        arr.Sort();
        // number of most encountered item
        int mostEncounter;

        // count of each unique element
        int maxCount = 0;
        
        // the most encountered type
        int mostEncounteredType = 0;

        //mostEncounteredType = arr.Where(x => x.Equals(arr.Max()));

        foreach (int element in arr)
        {
            int lastElementChecked = 0;

            // continue with the loop until it finds a new element
            if (element == lastElementChecked)
            {
                continue;
            }

            mostEncounter = arr.Where(x => x == element).Count();

            if (maxCount < mostEncounter)
            {
                maxCount = mostEncounter;
                mostEncounteredType = element;
                lastElementChecked = element;
            }
        }

        return mostEncounteredType;
    }


    public static void Main(string[] args)
    {
        // Example 1
        {
            // number of elements: 5
            // array: { 1, 1, 2, 2, 3 }
            List<int> arr = new List<int>(5) { 1, 1, 2, 2, 3 };

            // output: 1

            Helper.DisplayExample(
                "number of elementes: 5\n" +
                "array: { 1, 1, 2, 2, 3 }\n",
                "1");
            Console.WriteLine(migratoryBirds(arr));
        }
        Console.WriteLine(new string('-', 100));



        // Example 2
        {
            // number of elements: 6
            // array: { 1, 4, 4, 4, 5, 3 }
            List<int> arr = new List<int>(6) { 1, 4, 4, 4, 5, 3 };

            // output: 4

            Helper.DisplayExample(
                "number of elementes: 6\n" +
                "array: { 1, 4, 4, 4, 5, 3 }\n",
                "4");
            Console.WriteLine(migratoryBirds(arr));
        }
        Console.WriteLine(new string('-', 100));



        // Example 3
        {
            // number of elements: 11
            // array: { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 }
            List<int> arr = new List<int>(11) { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 };

            // output: 3

            Helper.DisplayExample(
                "number of elementes: 11\n" +
                "array: { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 }\n",
                "3");
            Console.WriteLine(migratoryBirds(arr));
        }
        Console.WriteLine(new string('-', 100));
    }
}