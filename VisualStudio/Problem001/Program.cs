//Multiples of 3 or 5

/*
 * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
 * 
 * Find the sum of all the multiples of 3 or 5 below 1000.
 */
int cap = 10;

List<int> multipleChecks = [3, 5];
List<int> answer = [];

for (int i = 1; i < cap; i++)
{
    foreach (int j in multipleChecks)
    {
        if (i % j == 0)
        {
            answer.Add(i);
            break;
        }
    }
}

Console.WriteLine($"Answer List: {string.Join(", ", answer)}");