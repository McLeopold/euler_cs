/*
Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:

1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
*/
using System;
using System.Collections.Generic;
using System.Linq;

static partial class Common
{
    public static IEnumerable<long> Fib(long first, long second) {
        yield return first;
        yield return second;
        while (true) {
            long next = first + second;
            first = second;
            second = next;
            yield return next;
        }
    }
}

public static class Problem_2
{
    public static long Solve(long limit)
    {
        return Common.Fib(1,2)
            .TakeWhile(x => x < limit)
            .Where(x => x % 2 == 0)
            .Sum();
    }
}
