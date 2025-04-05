using System.Diagnostics;
int result = Fibonacci(6);
Console.WriteLine(result);

static int Fibonacci(int x)
{
    Debug.WriteLine($"Entering {nameof(Fibonacci)} method");
    Debug.WriteLine($"We are looking for the {x}th number");

    int x1 = 0;
    int x2 = 1;
    int sum;

    for (int i = 2; i <= x; i++)
    {
        sum = x1 + x2;
        x1 = x2;
        x2 = sum;
        Debug.WriteLineIf(sum == 1, $"sum is 1, x1 is {x1}, x2 is {x2}");
    }
    Debug.Assert(x2 == 5, "The return value is not 5 and it should be.");
    return x == 0 ? x1 : x2;
}
