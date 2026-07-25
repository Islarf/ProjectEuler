//Largest Product in a Series

/*The four adjacent digits in the 1000-digit number that havbe the greatest product are 9x9x8x9 = 5832.
 * 
 * Find the thirteen adjacent digits int he 1000-digit number that have the greatest product. What is the value of this product.
 */


using EulerUtils;

string LargeNum = "73167176531330624919225119674" +
    "42657474235534919493496983520312774506326239578318016" +
    "984801869478851843858615607891129494954595017379583319" +
    "5285320880551112540698747158523863050715693290963295227" +
    "44304355766896648950445244523161731856403098711121722383" +
    "11362229893423380308135336276614282806444486645238749303" +
    "58907296290491560440772390713810515859307960866701724271" +
    "21883998797908792274921901699720888093776657273330010533" +
    "67881220235421809751254540594752243525849077116705560136" +
    "04839586446706324415722155397536978179778461740649551492" +
    "08625693219784686224828397224137565705605749026140797296865" +
    "2414535100474821663704844031998900088952434506585412275886" +
    "66881164271714799244429282308634656748139191231628245861786" +
    "6458359124566529476545682848912883142607690042242190226710" +
    "5562632111110937054421750694165896040807198403850962455444" +
    "362981230987879927244284909188845801561660979191338754992" +
    "0052406368991256071760605886116467109405077541002256983155" +
    "20005593572972571636269561882670428252483600823257530420752963450";

Console.WriteLine(Problem8.SolveRecur(LargeNum, 13));

public class Problem8
{
    public static long SolveLoop(string LargeNum, int adjacent = 4)
    {
        long maxProd = 0;
        for(int i = LargeNum.Length; i >= adjacent ; i--)
        {
            string substr = LargeNum.Substring(i - adjacent, adjacent);
            if (!substr.Contains("0"))
            {
                long temp = ProdOfString(substr);
                maxProd = maxProd > temp ? maxProd : temp;
            }
        }
        return maxProd;
    }

    public static long SolveRecur(string LargeNum, int adjacent = 4, int index = 0,  long maxProd = 1) => 
        index + adjacent > LargeNum.Length
        ? maxProd
        : SolveRecur(LargeNum, adjacent, index + 1, Math.Max(maxProd, ProdOfString(LargeNum.Substring(index, adjacent))));

    private static long ProdOfString(string substr) =>
        substr.Aggregate(1L, (prod, c) => prod * (c - '0'));
}