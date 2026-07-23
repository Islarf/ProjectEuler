using System.Data.SqlTypes;

namespace EulerUtils
{
    public class MathHelper
    {
        public static bool IsEven(int x) => x % 2 == 0;
        
        public static bool IsPrime(int testNumber)
        {
            if (testNumber == 2) return true; //return 2 if exactly 2
            if (testNumber <= 1 || IsEven(testNumber)) return false; // break immediately if even, or is 1 or less

            for(int oddNumber=3; oddNumber <= testNumber/2; oddNumber += 2)
            {
                if (testNumber % oddNumber == 0) return false;
            }

            return true;
        }
        
        //find the next prime number after a given number
        public static int NextPrime(int x)
        {
            x =
                x < 2
                ? 2
                :
                (x % 2 == 0
                 ? x + 1
                 : x + 2);

            return FindNextPrime(x);
        }
        private static int FindNextPrime(int x) =>
            IsPrime(x) ? x : FindNextPrime(x + 2);
        

        public static List<int> PrimeFactors(int x)
        {
            List<int> primeFactors = new List<int>();
            int start = 3;
            while(start < x)
            {

            }
            return primeFactors;
        }
    }
}

