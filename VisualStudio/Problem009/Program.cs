//Special Pythagorean Triplet

/*A Pythagorean triplet is a set of three natural numbers, a < b < c, for which:
 * ---------- a^2 + b^2 = c^2
 * 
 * for example: 3^2 + 4^2 = 9 + 16 = 25 = 5^2
 * 
 * There exists ONE pythagorean triple for which a + b + c = 1000.
 * Find the product of abc.
 */
using EulerUtils;
using System.Collections.Specialized;

Console.WriteLine(Problem9.SolveLoop(1000));


public class Problem9
{
    public static string SolveLoop(int cap = 12)
    {
        int a = 1; int b = 2;
        while (a < cap)
        {
            int c = (int)Math.Sqrt(a * a + b * b);
            //Console.WriteLine($"{a} + {b} + {c} = {cap} // {a} * {b} * {c} = {a * b * c}");
            if(a * a + b * b == c * c && a + b + c == cap)
            {
                return $"{a} + {b} + {c} = {cap} // {a} * {b} * {c} = {a * b * c}";
            }
            if(a+b+c > cap || b >= cap)
            {
                a++;
                b = a+1;
            }
            else
            {
                b++;
            }
        }
        return "None Found";
    }
}



// ²