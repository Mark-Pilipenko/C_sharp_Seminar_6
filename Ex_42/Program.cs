// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите a: ");
int a = Convert.ToInt32(Console.ReadLine());
To2(a);

void To2(int numb)
{
    string numb2 = string.Empty;
    while (numb != 0)
    {
        numb2 = numb2 + numb % 2;
        numb = numb / 2;
    }
    for (int i = numb2.Length - 1; i >= 0; i--)
    {
        Console.Write(numb2[i]);
    }
}

