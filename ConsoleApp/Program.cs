Console.WriteLine("Введіть значення X");
var EnteredX = Console.ReadLine();
var parsedX = int.TryParse(EnteredX, out int x);
Console.WriteLine("Введіть значення Y");
var EnteredY = Console.ReadLine();
var parsedY = int.TryParse(EnteredY, out int y);

int sum = 0;
if (!parsedX || !parsedY) {
    Console.WriteLine("Значення не валідні!");
    return;
}
else if (x < y) {
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