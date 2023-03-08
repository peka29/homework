// Напишите программу, которая на вход принимает два числа
// и выдает, какое число больше, а какое меньше.
// a = 5, b = 7 -> 7
// a = 2, b = 10 -> 10
// a = -3, b = -9 -> -3

Console.Clear();
Console.Write("Введите числа ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число ");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (a > b) max = a;
else
    max = b;
    Console.WriteLine($"Максимальное число {max}");
