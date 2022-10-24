// Задача 45: 
// Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.

int len = 6;
int min = 0;
int max = 10;

int[] rand = FillArray(len, min, max);
PrintArray(rand);
int[] copyrand = CopyArray(rand);
PrintArray(copyrand);

int[] FillArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int[] CopyArray(int[] array)
{
    int n = array.Length;
    int[] newarray = new int[n];
    for (int i = 0; i < n; i++)
    {
        newarray[i] = array[i];
    }
    return newarray;
}

void PrintArray(int[] array)
{
    int n = array.Length;
    for (int i = 0; i < n; i++)
    {
        if (i == n - 1) Console.WriteLine($"{array[i]}");
        else Console.Write($"{array[i]}, ");
    }
}