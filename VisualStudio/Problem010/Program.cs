//Summation of Primes

/* The sum of the primes below 10 is: 2 + 3 + 5 + 7 = 17
 * 
 * Find the sum of primes below (2,000,000)
 */
using EulerUtils;

Console.WriteLine(Problem10.Solve(2000000));

public class Problem10
{
    public static double Solve(double x = 10)
    {
        double curPrime = MathHelper.NextPrime(1);
        double sum = 0;
        while(curPrime < x)
        {
            //Console.WriteLine(curPrime);
            sum += curPrime;
            curPrime = MathHelper.NextPrime((long)curPrime);
        }
        return sum;
    }
}