// Напишите программу, которая на вход принамает число и выдает,
// является ли это число четным, делится ли на два.
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.Write("введите число для проверки на чётность: ");
int n1 = Convert.ToInt32(Console.ReadLine());
if (n1 % 2 == 0)
{
    Console.WriteLine("да");
}
else
    Console.WriteLine("нет");
    