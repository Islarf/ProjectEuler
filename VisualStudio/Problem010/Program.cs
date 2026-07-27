//Summation of Primes

/* The sum of the primes below 10 is: 2 + 3 + 5 + 7 = 17
 * 
 * Find the sum of primes below (2,000,000)
 */
using EulerUtils;

Console.WriteLine(Problem10.SolveRecur());

public class Problem10
{
    public static double Solve(int x = 10)
    {
        long curPrime = MathHelper.NextPrime(1);
        long sum = 0;
        while(curPrime < x)
        {
            //Console.WriteLine(curPrime);
            sum += curPrime;
            curPrime = MathHelper.NextPrime(curPrime);
        }
        return sum;
    }

    public static long SolveRecur(int cap = 10, long cur = 0, long sum = 0) =>
         cur > cap
            ? sum
            : SolveRecur(cap, MathHelper.NextPrime(cur), sum + cur);
}