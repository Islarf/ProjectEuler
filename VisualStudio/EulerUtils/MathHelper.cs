using System.Data.SqlTypes;

namespace EulerUtils
{
    public class MathHelper
    {
        public static bool IsEven(long x) => x % 2 == 0;
        
        public static bool IsPrime(long testNumber)
        {
            if (testNumber == 2) return true; //return 2 if exactly 2
            if (testNumber <= 1 || IsEven(testNumber)) return false; // break immediately if even, or is 1 or less

            for(long oddNumber=3; oddNumber <= (long)Math.Sqrt(testNumber); oddNumber += 2)
            {
                if (testNumber % oddNumber == 0) return false;
            }

            return true;
        }
        
        //find the next prime number after a given number
        public static long NextPrime(long x) => 
            FindNextPrime(
                x < 2
                ? 2
                : (x % 2 == 0
                    ? x + 1
                    : x + 2)
            );
        private static long FindNextPrime(long x) =>
            IsPrime(x) ? x : FindNextPrime(x + 2);

        private static long LastPrime(long x) =>
            FindLastPrime(
                x <= 2
                ? -1
                : x == 3 
                    ? 2 
                    : x % 2 == 0
                        ? x - 1
                        : x - 2
                );

        private static long FindLastPrime(long x) =>
            IsPrime(x) ? x : FindLastPrime(x - 2);


        public static long ListProduct(List<long> x) => x == null || x.Count == 0
            ? 0
            : NextProduct(1, 0, x);
        public static long NextProduct(long total, int index, List<long> list) =>
            index == list.Count
            ? total
            : NextProduct(total * list[index], index + 1, list);
        
        
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
                    ? GetPrimeFactors(x/start, start, ListAppend(primeFactors, start))
                     : GetPrimeFactors(x, (start == 2 ? 3 : start + 2), primeFactors);
        
    }
}

