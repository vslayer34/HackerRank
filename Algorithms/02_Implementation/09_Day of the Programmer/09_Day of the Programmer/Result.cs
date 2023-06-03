using System;

internal class Result
{
    public static string dayOfProgrammer(int year)
    {
        int dayOfTheProgrammer = 255;

        DateTime date = new DateTime(year, 1, 1);

        if (year == 1918)
        {
            date = date.AddDays(dayOfTheProgrammer + 13);
        }
        else if (year > 1917)
        {
            date = date.AddDays(dayOfTheProgrammer);
        }
        else if (year % 4 == 0 && year % 100 == 0)
        {
            date = date.AddDays(dayOfTheProgrammer - 1);
        }
        else
        {
            date = date.AddDays(dayOfTheProgrammer);
        }

        return date.ToString("dd.MM.yyyy");
    }

    public static void Main(string[] args)
    {
        // Example 1
        {
            // input: 1984
            // output: 12.09.1984

            int year = 1984;

            Helper.DisplayExample("the given year = 1984", "12.09.1984");
            Console.WriteLine(dayOfProgrammer(year));
        }
        Console.WriteLine(new string('-', 100));



        // Example 2
        {
            // input: 2017
            // output: 13.09.2017

            int year = 2017;

            Helper.DisplayExample("the given year = 2017", "13.09.2017");
            Console.WriteLine(dayOfProgrammer(year));
        }
        Console.WriteLine(new string('-', 100));



        // Example 3
        {
            // input: 2016
            // output: 12.09.2016

            int year = 2016;

            Helper.DisplayExample("the given year = 2016", "12.09.2016");
            Console.WriteLine(dayOfProgrammer(year));
        }
        Console.WriteLine(new string('-', 100));



        // Example 4
        {
            // input: 1800
            // output: 12.09.1800

            int year = 1800;

            Helper.DisplayExample("the given year = 1800", "12.09.1800");
            Console.WriteLine(dayOfProgrammer(year));
        }
        Console.WriteLine(new string('-', 100));



        // Example 5
        {
            // input: 1917
            // output: 13.09.1917

            int year = 1917;

            Helper.DisplayExample("the given year = 1917", "13.09.1917");
            Console.WriteLine(dayOfProgrammer(year));
        }
        Console.WriteLine(new string('-', 100));



        // Example 6
        {
            // input: 1916
            // output: 12.09.1916

            int year = 1916;

            Helper.DisplayExample("the given year = 1916", "12.09.1916");
            Console.WriteLine(dayOfProgrammer(year));
        }
        Console.WriteLine(new string('-', 100));



        // Example 7
        {
            // input: 1836
            // output: 12.09.1836

            int year = 1836;

            Helper.DisplayExample("the given year = 1836", "12.09.1836");
            Console.WriteLine(dayOfProgrammer(year));
        }
        Console.WriteLine(new string('-', 100));



        // Example 8
        {
            // input: 1918
            // output: 26.09.1918

            int year = 1918;

            Helper.DisplayExample("the given year = 1918", "26.09.1918");
            Console.WriteLine(dayOfProgrammer(year));
        }
        Console.WriteLine(new string('-', 100));
    }
}