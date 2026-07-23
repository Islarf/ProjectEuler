// Largest Prime Factor

/*
 * The prime factors of '13195' are 5, 7, 13, and 29.
 * 
 * What is the largest prime factor of the number 600851475143?
 */

using EulerUtils;//so i have access to MathHelper.cs

int x = 13195;
List<long> pfs = MathHelper.PrimeFactors(x);

Console.WriteLine($"" +
    $"The prime factors of ({x}) are: {String.Join(", ", pfs)}");