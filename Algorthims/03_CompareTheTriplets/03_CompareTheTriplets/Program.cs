using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Drawing;
using System.Reflection.Metadata;

// URL: https://www.hackerrank.com/challenges/compare-the-triplets/problem?isFullScreen=true

/*Alice and Bob each created one problem for HackerRank.
 * A reviewer rates the two challenges, awarding points on a scale from 1 to 100 for three categories: problem clarity, originality, and difficulty. 
 * The rating for Alice's challenge is the triplet a = (a[0], a[1], a[2]), and the rating for Bob's challenge is the triplet b = (b[0], b[1], b[2]).
 * The task is to find their comparison points by comparing a[0] with b[0], a[1] with b[1], and a[2] with b[2]. 
 *  
 *  If a[i] > b[i], then Alice is awarded 1 point. 
 *  If a[i] < b[i], then Bob is awarded 1 point. 
 *  If a[i] = b[i], then neither person receives a point.
 *  
 *  Comparison points is the total points a person earned. 
 *  Given a and b, determine their respective comparison points. 
 */

class Result
{

    /*
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        List<int> finalScore = new List<int>(){ 0, 0 };

        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] > b[i])
                finalScore[0]++;
            else if (a[i] < b[i])
                finalScore[1]++;
        }

        return finalScore;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        // Example 1
        {
            // a = [1, 2, 3]
            // b = [3, 2, 1] 
            // For elements *0*, Bob is awarded a point because a[0].
            // For the equal elements a[1] and b[1], no points are earned.
            // Finally, for elements 2, a[2] > b[2] so Alice receives a point. 

            // The return array is [1, 1] with Alice's score first and Bob's second. 

            List<int> a = new List<int>(){ 1, 2, 3 };
            List<int> b = new List<int>() { 3, 2, 1 };
            var result = Result.compareTriplets(a, b);

            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
        }
        Console.WriteLine(new string('-', 100));

        // sample input and output 0
        {
            // a = [5, 6, 7]
            // b = [3, 6, 10]

            // output = [1, 1]

            List<int> a = new List<int>() { 5, 6, 7 };
            List<int> b = new List<int>() { 3, 6, 10 };
            var result = Result.compareTriplets(a, b);

            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
        }
        Console.WriteLine(new string('-', 100));


        // sample input and output 1
        {
            // a = [17, 28, 30]
            // b = [99, 16, 8]

            // output = [2, 1]
            List<int> a = new List<int>() { 17, 28, 30 };
            List<int> b = new List<int>() { 99, 16, 8 };
            var result = Result.compareTriplets(a, b);

            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
        }
        Console.WriteLine(new string('-', 100));
    }
}
