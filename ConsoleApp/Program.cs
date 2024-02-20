// Write to Console number from 1 to n;
int num = 5;
int start = 1;
Rec(num, start);
Writeline(6);
// First option
static void Writeline (int n) {
   for (int i =1; i <= n; i++)
   Console.WriteLine(i);
};

// Second option
static void Rec(int num, int start)
{
   if (num >= start)
   {
      Console.WriteLine(start);
      Rec(num, start +1);
   }

};

// Create Method Factorial
Console.WriteLine(Factorial(7));

int Factorial (int n) {
if (n==1) return n;
return n*Factorial(n-1);
}


 


