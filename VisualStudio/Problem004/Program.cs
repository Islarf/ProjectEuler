
// Largest Palindrome Product

/*
 * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 x 99.
 * 
 * Fine the largest palindrome made from the product of two 3-digit numbers.
 * 
 */

Problem4.Solve(2);

public static class Problem4
{
    public static void Solve(int digits)
    {
        //Creates string with (digit) length of all 9's.
        int targetStr = int.Parse(new string('9', digits));
        int MaxProd = targetStr * targetStr;
        Console.Write($"Max Prod of {targetStr} * {targetStr} => {MaxProd}");
    }

    private static bool isPalindrome(string var) => 
        var.Equals(new String(var.Reverse().ToArray()), StringComparison.OrdinalIgnoreCase);
    
}