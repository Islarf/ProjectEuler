//Smallest Multiple

/* 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without remainder.
 * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
 */
using EulerUtils;//so i have access to MathHelper.cs


using System.Globalization;

Problem5.SolveLoop(20);

public static class Problem5
{
    public static void SolveLoop(int cap = 20)
    {
        int currentNumber = cap;
        int i = cap;
        while (i >= 2)
        {
            //Console.WriteLine($"Current Number: {currentNumber}");
            //Console.WriteLine($"i : {i}");

            if (currentNumber % i == 0) { i--; }

            else {
                i = cap;
                currentNumber += cap; 
            }
            
        }
        Console.Write(currentNumber);
    }


    //impracticle in this scenario. does not work if the number is large because of space
    public static void SolveRecur(int cap = 20)
    {
        int maxnumber = NextNumber(cap, cap, cap);
        Console.WriteLine(maxnumber);
    }
    private static int NextNumber(int current, int i, int cap)
    {
        if (i >= 2)
        {
            if (current % i == 0)
            {
                return NextNumber(current, i - 1, cap);
            }
            else
            {
                return NextNumber(current + cap, cap, cap);
            }
        }
        else
        {
            return current;
        }
    }
}