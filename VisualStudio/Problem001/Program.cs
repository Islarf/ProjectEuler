//Multiples of 3 or 5

/*
 * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
 * 
 * Find the sum of all the multiples of 3 or 5 below 1000.
 */

using System.Numerics;
using System.Runtime.CompilerServices;

int cap = 1000;
/*
 * SolutionLoop x = new SolutionLoop();
 * x.Solve(cap);
 * Console.Write(x.AnswerList.Sum());
*/



SolutionRecursive x = new SolutionRecursive();
int sum = x.Solve(cap-1);
Console.WriteLine($"Answer: {sum}");

//RecursiveAnswer
class SolutionRecursive
{
    private static bool Log(string msg) { Console.WriteLine(msg); return true; }

    public int Solve(int current) =>
        //Base Case: stop when hit 0
        current <= 0
            ? 0
            : (current % 100 == 0 && Log($"[Progress] Processing {current}"), //bool logging trick?
             (current % 3 == 0 || current % 5 == 0 ? current : 0) //item 2: recursive math
            + Solve(current - 1)).Item2;
}

//LOOP ANSWER
class SolutionLoop
{
    public List<int> AnswerList = new List<int>();
    public void Solve(int cap)
    {
        Console.WriteLine("Running Loop Solution...");
        AnswerList.Clear();
        for (int i = cap-1; i > 0; i--)
        {
            if(i%5==0 || i%3==0)
            {
                AnswerList.Add(i);
            }
        }
        return;
    }
}


//Answer is: 233168