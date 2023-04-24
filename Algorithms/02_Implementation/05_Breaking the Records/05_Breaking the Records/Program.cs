using System;

internal class Result
{
    public static List<int> breakingRecords(List<int> scores)
    {
        int lowestScore = scores[0];
        int highestScore = scores[0];

        // counter for highest and lowest score record broken
        int lowestRecord = 0;
        int highestRecord = 0;

        foreach (int score in scores)
        {
            if (score < lowestScore)
            {
                lowestScore = score;
                lowestRecord++;
            }

            if (score > highestScore)
            {
                highestScore = score;
                highestRecord++;
            }
        }

        return new List<int>() { highestRecord, lowestRecord };
    }

    //****************************************************************************************

    public static void Main(string[] args)
    {
        // Example 1
        {
            // input number: 9
            // input List" { 10, 5, 20, 20, 4, 5, 2, 25, 1 }
            // first number represents number of highest score broken record
            // second number represents number of lowest score broken record
            // output: 2 4

            List<int> score = new List<int>(9) { 10, 5, 20, 20, 4, 5, 2, 25, 1 };

            Helper.DisplayExample(
                "Matches: 9\n" +
                "Scores : { 10, 5, 20, 20, 4, 5, 2, 25, 1 }\n",
                "2 4");
            Console.Write(Result.breakingRecords(score)[0] + " ");
            Console.WriteLine(Result.breakingRecords(score)[1]);
        }
        Console.WriteLine(new string('-', 100));



        // Example 2
        {
            // input number: 10
            // input List" { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 }
            // first number represents number of highest score broken record
            // second number represents number of lowest score broken record
            // output: 2 4

            List<int> score = new List<int>(10) { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 };

            Helper.DisplayExample(
                "Matches: 10\n" +
                "Scores : { 3, 4, 21, 36, 10, 28, 35, 5 , 24, 42 }\n",
                "4 0");
            Console.Write(Result.breakingRecords(score)[0] + " ");
            Console.WriteLine(Result.breakingRecords(score)[1]);
        }
        Console.WriteLine(new string('-', 100));
    }
}