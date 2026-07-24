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

            for (long oddNumber = 3; oddNumber <= (long)Math.Sqrt(testNumber); oddNumber += 2)
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

        //Double is used to support Negative powers
        public static double PowerOf(double x, long repeat = 2)
        {
            return repeat < 0 
                ? 1.0 / PowerOf(x, -repeat)
                : repeat == 0 
                    ? 1 
                    : x * PowerOf(x, repeat - 1);
        }
        
    }
}

