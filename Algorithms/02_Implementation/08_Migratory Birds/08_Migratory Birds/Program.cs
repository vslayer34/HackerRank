using System;

internal class Result
{
    public static int migratoryBirds(List<int> arr)
    {
        // sort array
        arr.Sort();

        // Dicitionary to store the elements and the number of its encounter
        Dictionary<int, int> map = new Dictionary<int, int>();

        // fill the dictionery with the elements and its count
        int lastElementChecked = 0;
        foreach (int i in arr)
        {            
            if (i == lastElementChecked)
            {
                map[i]++;
                continue;
            }

            lastElementChecked = i;
            map.Add(i, 1);
        }

        // return THe first element ket that has the most values
        return map.Keys.First(x => map[x] == map.Values.Max());
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