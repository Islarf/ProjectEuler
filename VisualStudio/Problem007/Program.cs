//10,001's prime

/* By listing the first six prime numbers, 2,4,5,7,11, and 13: we can see the 6th prime is 13.
 * What is the 10,001'st prime number?
 */

using EulerUtils;//so i have access to MathHelper.cs

Console.WriteLine(Problem7.SolveRecur(10001));

public class Problem7
{
    public static int SolveLoop(int cap = 6)
    {
        int xthPrime = 2;
        for(int i = cap; i > 1; i--)
        {
            xthPrime = (int)MathHelper.NextPrime(xthPrime);
        }
        return xthPrime;
    }

    public static int SolveRecur(int cap = 6, int xthPrime = 2) => 
        cap > 1 
        ? SolveRecur(cap - 1, (int)MathHelper.NextPrime(xthPrime)) 
        : xthPrime;
    
}