/*
The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?
*/
using System;
using System.Collections.Generic;
using System.Linq;

static partial class Common
{
    public static IEnumerable<long> Factor(long num)
    {
        for (long fac = 2; fac <= Math.Sqrt(num); fac++)
        {
            while (num % fac == 0)
            {
                yield return fac;
                num /= fac;
            }
        }
        if (num > 1) yield return num;
    }
}

public static class Problem_3
{
    public static long Solve(long limit)
    {
        return Common.Factor(limit).Last();
    }
}
