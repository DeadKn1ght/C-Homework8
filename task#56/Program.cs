// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"[ {arr[i, j]} ] ");
        }
        System.Console.WriteLine();
    }
}
void MinRow(int[,] arr)
{
    System.Console.WriteLine();
    int summMinRow = 0;
    int minRow = 0;
    int summRow = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        summMinRow += arr[0, j];
    }
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            summRow += arr[i, j];
        }
        if (summMinRow > summRow)
        {
            minRow = i;
            summMinRow = summRow;
        }
        summRow = 0;
    }
    System.Console.WriteLine($"Row with minimum value is {minRow + 1}");
}

System.Console.WriteLine("Input Length of your array, rows :");
int numberM = int.Parse(Console.ReadLine());
System.Console.WriteLine("Input Length of your array, columns :");
int numberN = int.Parse(Console.ReadLine());
int[,] array = new int[numberM, numberN];
System.Console.WriteLine("Your array is :");
FillArray(array);
PrintArray(array);
MinRow(array);