using System;
using System.Text;

internal class Result
{
    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> result = new List<int>();

        foreach (int grade in grades)
        {
            if (grade < 37)
            {
                result.Add(grade);
            }
            else if (grade % 5 > 2)
            {
                // subtract the mod from the grade
                // and add 5 to round the grade up
                int temp = grade - (grade % 5);
                Console.WriteLine(temp);
                result.Add(temp + 5);
            }
            else
            {
                result.Add(grade);
            }
        }

        return result;
    }

    public static string ToSring(List<int> grades)
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("[ ");
        foreach (int grade in grades)
        {
            sb.Append(grade + ", ");
        }
        sb.Remove(sb.Length - 2, 2);
        sb.Append(" ]");

        return sb.ToString();
    }

    //*****************************************************************************************************

    public static void Main(string[] args)
    {
        // Example 1
        {
            // input: 73, 67, 38, 33
            // output: 75, 67, 40, 33

            List<int> grades = new List<int>() { 73, 67, 38, 33 };
            List<int> output = new List<int>() { 75, 67, 40, 33 };

            Helper.DisplayExample(Result.ToSring(grades) + '\n', Result.ToSring(output));
            Console.WriteLine(Result.ToSring(Result.gradingStudents(grades)));
        }
        Console.WriteLine(new string('-', 100));


    }
}