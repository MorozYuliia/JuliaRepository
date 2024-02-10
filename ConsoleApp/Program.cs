internal class Program
{
    private static void Main(string[] args)
    {
        const int N = 8;
        var result = 1;
        int firstValue = 1;
        int secondValue = 1;
        for (int i = 2; i <= N - 1; ++i)
        {
            result = firstValue + secondValue;
            firstValue = secondValue;
            secondValue = result;
        };
        Console.WriteLine($"{N}-е Фібаначчі число це: {result}");

        Console.WriteLine(MaxValue(5, 1));
        Console.WriteLine(MaxValue(3, 15, 7));
        Console.WriteLine(MaxValue(5, 5, 7, 7));

    }
    
        // First Max Method
        static int MaxValue(int a, int b)
        {
            int result = 0;
            if (a > b)
            {
                result = a;
            }
            else if (b > a)
            {
                result = b;
            }
            else if (b == a)
            {
                result = a;
            }
            return result;
        }

        // Second Max Method
        static int MaxValue(int a, int b, int c)
        {
            int result = 0;
            if (a >= b && a >= c)
            {
                result = a;
            }
            else if (b >= a && b >= c)
            {
                result = b;
            }
            else if (c >= a && c >= b)
            {
                result = c;
            }
            else if (a == b && b == c)
            {
                result = a;
            }
            return result;
        }

        // Third Max Method
        static int MaxValue(int a, int b, int c, int d)
        {
            int result = 0;
            if (a >= b && a >= c && a >= d)
            {
                result = a;
            }
            else if (b >= a && b >= c && b >= d)
            {
                result = b;
            }
            else if (c >= a && c >= b && c >= d)
            {
                result = c;
            }
            else if (d >= a && d >= b && d >= c)
            {
                result = d;
            }
            else if (a == b && b == c && c == d)
            {
                result = a;
            }
            return result;
        }
}