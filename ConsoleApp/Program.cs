const int N = 8;
var result = 1;
int firstValue = 1;
int secondValue = 1;

for (int i = 2; i <=N-1; ++i) {
    result = firstValue + secondValue;
    firstValue = secondValue;
    secondValue = result;
    
};
Console.WriteLine($"{N}-th Фібаначчі число це: {result}");