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

class Result
{

    /*
     * Complete the 'larrysArray' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER_ARRAY A as parameter.
     */
     class Fenwick
    {
        readonly int n;
        readonly int[] bit;
        public Fenwick(int size)
        {
            n = size;
            bit = new int[n + 1];
        }
        public void Add(int idx, int val = 1)
        {
            for (; idx <= n; idx += idx & -idx)
                bit[idx] += val;
        }
        public int Sum(int idx)
        {
            int s = 0;
            for (; idx > 0; idx -= idx & -idx)
                s += bit[idx];
            return s;
        }
    }

    public static string larrysArray(List<int> A)
    {
        int n = A.Count;
        Fenwick fw = new Fenwick(n);
        long inversions = 0;

        for (int i = 0; i < n; i++)
        {
            int seenSoFar = i;
            int leq = fw.Sum(A[i]);
            inversions += (seenSoFar - leq);
            fw.Add(A[i], 1);
        }

        return (inversions % 2 == 0) ? "YES" : "NO";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> A = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(ATemp => Convert.ToInt32(ATemp)).ToList();

            string result = Result.larrysArray(A);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
