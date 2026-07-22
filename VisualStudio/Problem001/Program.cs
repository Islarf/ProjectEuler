//Multiples of 3 or 5

/*
 * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
 * 
 * Find the sum of all the multiples of 3 or 5 below 1000.
 */
int cap = 1000;

List<int> answer = [];
//int RealAnswer = 0;

for (int i = cap-1; i > 0; i--)
{
    if(i%5==0 || i%3==0)
    {
        answer.Add(i);
        //RealAnswer += i;
    }
}

Console.WriteLine($"Answer: {string.Join(", ", answer)}");

Console.WriteLine($"Sum Of: {answer.Sum()}");

//Answer is: 233168