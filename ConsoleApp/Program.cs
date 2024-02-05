int x = 3;
int y = 3;
int sum = 0;
if (x < y) {
    for (int i = x; i<=y; i++) {
        sum +=i;
    }
    Console.WriteLine($"Сума чисел: {sum}");
}
else if (x >y) {
    for (int i = y; i<=x; i++) {
        sum +=i;
    }
     Console.WriteLine($"Сума чисел: {sum}");
}
else if (x == y) {
    sum = x;
    Console.WriteLine($"Сума чисел: {sum}");
}