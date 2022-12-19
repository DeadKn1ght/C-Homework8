// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void MinMaxOrder(int[,] arr)
{
    System.Console.WriteLine();
    int max = 0;
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int k = 0; k < arr.GetLength(1) - 1; k++)
        {
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {
                max = arr[i, j];
                if (arr[i, j + 1] > max)
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[i, j + 1];
                    arr[i, j + 1] = temp;
                }
                max = 0;
                temp = 0;
            }
        }
    }

}

System.Console.WriteLine("Input Length of your array, rows :");
int numberM = int.Parse(Console.ReadLine());
System.Console.WriteLine("Input Length of your array, columns :");
int numberN = int.Parse(Console.ReadLine());
int[,] array = new int[numberM, numberN];
System.Console.WriteLine("Your array is :");
FillArray(array);
PrintArray(array);
MinMaxOrder(array);
System.Console.WriteLine("Ordered from max array is :");
PrintArray(array);
