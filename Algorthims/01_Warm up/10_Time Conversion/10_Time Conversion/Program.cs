using System;
using System.Globalization;

internal class Result
{
    public static string timeConversion(string s)
    {
        DateTime date = DateTime.Parse(s);

        return date.ToString("HH:mm:ss");
    }


    //*************************************************************************************************************
    public static void Main(string[] args)
    {
        // Example 1
        {
            // input: "12:01:00PM"
            // output: "12:01:00"
            string time = "12:01:00PM";

            Helper.DisplayExample(time + '\n', "12:01:00");
            Console.WriteLine(Result.timeConversion(time));
        }
        Console.WriteLine(new string('-', 100));



        // Example 2
        {
            // input: "12:01:00AM"
            // output: "00:01:00"
            string time = "12:01:00AM";

            Helper.DisplayExample(time + '\n', "00:01:00");
            Console.WriteLine(Result.timeConversion(time));
        }
        Console.WriteLine(new string('-', 100));



        // Example 3
        {
            // input: "07:05:45PM"
            // output: "19:05:45"
            string time = "07:05:45PM";

            Helper.DisplayExample(time + '\n', "19:05:45");
            Console.WriteLine(Result.timeConversion(time));
        }
        Console.WriteLine(new string('-', 100));
    }
}