// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
//  добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                System.Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
                System.Console.WriteLine();
            }
        }
    }
}

// System.Console.WriteLine("Input Length of your 1-st matrix, rows :");
// int numberM = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Input Length of your 1-st matrix, columns :");
// int numberN = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Input Length of your 1-st matrix, deep :");
// int numberZ = int.Parse(Console.ReadLine());
// int[,,] array = new int[numberM, numberN, numberZ];
int[,,] array = new int[2, 2, 2];
System.Console.WriteLine("Your array is :");
FillArray(array);
PrintArray(array);