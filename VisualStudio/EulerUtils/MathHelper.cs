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

    }
}

