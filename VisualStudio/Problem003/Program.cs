// Largest Prime Factor

/*
 * The prime factors of '13195' are 5, 7, 13, and 29.
 * 
 * What is the largest prime factor of the number 600851475143?
 */

using EulerUtils;//so i have access to MathHelper.cs

long x = 600851475143;

Problem3.Solve(x);



public static class Problem3
{
    public static void Solve(long input)
    {
        List<long> primefactors = PrimeFactors(input);
        Console.WriteLine($"" +
        $"The prime factors of ({input}) are: {String.Join(", ", primefactors)}" +
        $"\nThe Largest prime factor of this is {primefactors.Max()}");
    }

    private static List<long> ListAppend(List<long> x, long y) { x.Add(y); return x; }

    public static List<long> PrimeFactors(long x) =>
            x < 2
            ? new List<long>()
            : GetPrimeFactors(x, 2, new List<long>());

    private static List<long> GetPrimeFactors(long x, long start, List<long> primeFactors) =>
        x < 2
        ? primeFactors
        : start * start > x
            ? ListAppend(primeFactors, x)
            : x % start == 0
                ? GetPrimeFactors(x / start, start, ListAppend(primeFactors, start))
                 : GetPrimeFactors(x, (start == 2 ? 3 : start + 2), primeFactors);
}


//answer: 6857