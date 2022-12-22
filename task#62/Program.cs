// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

void Spiral(int [,]arr,int n,int m)
{
    int row = 0; int col = 0;
    int dx = 1; int dy = 0;
    int dirChanges = 0;
    int visits = m;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[row, col] = i + 1;
        if (--visits == 0)
        {
            visits = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        col += dx;
        row += dy;
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < 10)
                System.Console.Write($"0{arr[i, j]} ");
            else
                System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

const int n = 4;
const int m = 4;
int[,] array = new int[n, m];
Spiral(array,n,m);
PrintArray(array);