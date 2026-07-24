//Sum Square Difference

/* The sum of the squares of the first ten (10) natural numbers is:
 * ----------- 1^2 + 2^2 + ... 10^2 = 385
 * 
 * The square of the sum of the first ten (10) natural numbers is
 * ----------- (1+2+...+10)^2 = 55 = 3025
 * 
 * Hence the difference between the sum of the squares of the first ten (10) natural numbers, and the square of the sum is: 
 * ----------- 3025 - 385 = 2640
 * 
 * Find the difference between the sum of the squares of the first one hundred (100) natural numbers, and the square of the sum.
 */

using EulerUtils;//so i have access to MathHelper.cs

Console.Write(MathHelper.PowerOf(7));


public static class Problem6
{
    public static void SolveLoop(int cap = 10)
    {
        int sum = 0;
        //sum of squares
        for(int i = cap; i > 1; i--)
        {
            sum = MathHelper.PowerOf(i);
        }
    }
}