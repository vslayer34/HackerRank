using System;

internal class Result
{
    public static void bonAppetit(List<int> bill, int k, int b)
    {
        int AnnaCheck = 0;

        for (int i = 0; i < bill.Count; i++)
        {
            if (i == k)
                continue;

            AnnaCheck += bill[i];
        }
        AnnaCheck /= 2;

        if (b == AnnaCheck)
            Console.WriteLine("Bon Appetit");
        else
            Console.WriteLine(b - AnnaCheck);
    }

    public static void Main(string[] args)
    {
        // Example 1
        {
            // input what Anna skiped: 1;
            // Bill Sheet: { 3, 10, 2, 9 }
            // what Anna paid: 12
            // output: 5

            int annaSkiped = 1;
            List<int> bill = new List<int>(4) { 3, 10, 2, 9 };
            int annaPaid = 12;

            Helper.DisplayExample(
                "Bill Sheet: { 3, 10, 2, 9 }\n" +
                "Anaa Paid: 12\n" +
                "Anna Skipped: 1\n",
                "5");
            bonAppetit(bill, annaSkiped, annaPaid);
        }
        Console.WriteLine(new string('-', 100));



        // Example 2
        {
            // input what Anna skiped: 1;
            // Bill Sheet: { 3, 10, 2, 9 }
            // what Anna paid: 7
            // output: Bon Appetit

            int annaSkiped = 1;
            List<int> bill = new List<int>(4) { 3, 10, 2, 9 };
            int annaPaid = 7;

            Helper.DisplayExample(
                "Bill Sheet: { 3, 10, 2, 9 }\n" +
                "Anaa Paid: 7\n" +
                "Anna Skipped: 1\n",
                "Bon Appetit");
            bonAppetit(bill, annaSkiped, annaPaid);
        }
        Console.WriteLine(new string('-', 100));
    }
}