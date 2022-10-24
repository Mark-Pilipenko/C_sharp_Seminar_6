// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите a: ");
int a = Convert.ToInt32(Console.ReadLine());
int first = 0;
int second = 1;
int next = 0;
Console.Write("0 ");
if (a > 1) Console.Write("1 ");
for (int i = 3; i <= a; i++)
{
        next = first + second;
        Console.Write($"{next} ");
        first = second;
        second = next;
}