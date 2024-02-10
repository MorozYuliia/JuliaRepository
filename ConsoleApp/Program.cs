using System.Xml.Linq;
using Microsoft.VisualBasic;

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
        Console.WriteLine("MaxValues");
        Console.WriteLine(MaxValue(5, 1));
        Console.WriteLine(MaxValue(3, 15, 7));
        Console.WriteLine(MaxValue(5, 5, 7, 7));
        Console.WriteLine("MinValues");
        Console.WriteLine(MinValue(17, 9));
        Console.WriteLine(MinValue(6, 62, 47));
        Console.WriteLine(MinValue(35, 43, 91, 75));
        Console.WriteLine("TrySumIfOdd");
         int sum = 0;
         bool success = TrySumIfOdd(17, 10, out sum);
        Console.WriteLine($"Success: {success}, sum: {sum}");
        Console.WriteLine("RepeatFunction");
        Console.WriteLine(RepeatFunction ("a", 5));
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
        // First Min Method
        static int MinValue(int a, int b)
        {
            int result = 0;
            if (a < b)
            {
                result = a;
            }
            else if (b < a)
            {
                result = b;
            }
            else if (b == a)
            {
                result = a;
            }
            return result;
        }
        // Second Min Method
        static int MinValue(int a, int b, int c)
        {
            int result = 0;
            if (a <= b && a <= c)
            {
                result = a;
            }
            else if (b <= a && b <= c)
            {
                result = b;
            }
            else if (c <= a && c <= b)
            {
                result = c;
            }
            else if (a == b && b == c)
            {
                result = a;
            }
            return result;
        }
        // Third Min Method
        static int MinValue(int a, int b, int c, int d)
        {
            int result = 0;
            if (a <= b && a <= c && a <= d)
            {
                result = a;
            }
            else if (b <= a && b <= c && b <= d)
            {
                result = b;
            }
            else if (c <= a && c <= b && c <= d)
            {
                result = c;
            }
            else if (d <= a && d <= b && d <= c)
            {
                result = d;
            }
            else if (a == b && b == c && c == d)
            {
                result = a;
            }
            return result;
        }
       
        static bool TrySumIfOdd (int a, int b, out int sum) {
            if ((a + b)%2 == 0) {
                 sum = a + b;
                return false;
            }
            else {
                 sum = a + b;
                return true;
            }
        }
        // Method Repeat
        static string RepeatFunction (string X, int N) {
            bool resultInputN;
            string result = "a";
            Console.WriteLine("Введіть слово");
            X = Console.ReadLine();
            Console.WriteLine("Введіть кількість повторень");
            var inputN = Console.ReadLine();
            resultInputN = int.TryParse(inputN, out N);
            if (resultInputN == false) {
            Console.WriteLine("Введіть число");
             result = "Fail!!!!!";
            return result;
            }
            else if (resultInputN == true) {
            result = string.Concat(Enumerable.Repeat(X, N));
            return result;
            }
            return result;
        }
}

