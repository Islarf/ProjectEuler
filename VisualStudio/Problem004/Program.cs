
// Largest Palindrome Product

/*
 * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 x 99.
 * 
 * Fine the largest palindrome made from the product of two 3-digit numbers.
 * 
 */

//Recursion BREAKS with 6, you need to use LOOP for larger numbers.
Console.WriteLine(Problem4.SolveRecur(3));

public static class Problem4
{
    public static void SolveLoop(int digits)
    {
        //Creates string with (digit) length of all 9's.

        int MIN = (int)Math.Pow(10, digits - 1);
        int MAX = (int)Math.Pow(10, digits) - 1;
        int MaxPalindrome = 0;
        //for display purposes
        int MaxA = 0;
        int MaxB = 0;
        for(int value1 = MIN; value1 <= MAX; value1 += 1)
        {
            for(int value2 = MIN; value2 <= MAX; value2 += 1)
            {
                int prod = value1 * value2;
                if(prod>MaxPalindrome && IsPalindrome(prod.ToString()))
                {
                    MaxPalindrome = prod;
                    MaxA = value1;
                    MaxB = value2;
                }
            }
        }
        Console.Write($"[LOOP]: The largest palindrome of {MaxA} * {MaxB} is : {MaxPalindrome}");
        //Console.Write($"Max Prod of {targetStr} * {targetStr} => {MaxProd}");
    }

    public static int SolveRecur(int digits)
    {
        int MIN = (int)Math.Pow(10, digits - 1);
        int MAX = (int)Math.Pow(10, digits) - 1;
        return FindMaxPalindrome(MAX, MAX, MIN, 0);
    }
    private static int FindMaxPalindrome(int a, int b, int min, int maxPalindrome) =>
        a < min 
        ? maxPalindrome
        : b < min || a * b <= maxPalindrome
            ? FindMaxPalindrome(a-1, a-1, min, maxPalindrome)
            : FindMaxPalindrome(a, b-1, min, 
                (IsPalindrome((a*b).ToString()) ? Math.Max(maxPalindrome,a*b) : maxPalindrome)
         );
        
    private static bool IsPalindrome(string var) => 
        var.Equals(new String(var.Reverse().ToArray()), StringComparison.OrdinalIgnoreCase);
    
    
}
