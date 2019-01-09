using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public static void Main(string[] args)
    {
        int[] intArray = new int[args.Length];
        for(int i = 0; i < args.Length; i++)
        {
            intArray[i] = int.Parse(args[i]);
        }
        solution(intArray);
    }
    public static int solution(int[] A)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        Array.Sort(A);
        int left = 0;
        int right = A.Length - 1;
        long latestVal = long.MaxValue;
        long lowestAbsSum = long.MaxValue;
        while(left <= right)
        {
            long newVal = Math.Abs(A[left] + A[right]);
            if(newVal <= latestVal)
            {
                right--;
                latestVal = newVal;
                if(newVal < lowestAbsSum)
                {
                    lowestAbsSum = newVal;
                }
            }
            else
            {
                right++;
                left++;
                latestVal = long.MaxValue;
            }
        }
        return (int)lowestAbsSum;
    }
}