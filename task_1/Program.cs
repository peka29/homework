// Напишите программу, которая на вход принимает два числа
// и выдает, какое число больше, а какое меньше.
// a = 5, b = 7 -> 7
// a = 2, b = 10 -> 10
// a = -3, b = -9 -> -3

Console.Clear();
Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if (a > b) max = a;
else
    max = b;
if (a < b) min = a;
else
    min = b;
    Console.WriteLine($"Максимальное число {max}");
    Console.WriteLine($"Минимальное число {min}");
