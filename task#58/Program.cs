// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

bool MultiplicationAbleMatrix(int M, int N, int L, int Z)
{
    bool flag = false;
    if (M == L || N == L || M == Z || N == Z)
    {
        System.Console.WriteLine("Multiplication of your matrixes is :");
        flag = true;
    }
    return flag;
}

int[,] Multiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] r = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                r[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return r;
}

System.Console.WriteLine("Input Length of your 1-st matrix, rows :");
int numberM = int.Parse(Console.ReadLine());
System.Console.WriteLine("Input Length of your 1-st matrix, columns :");
int numberN = int.Parse(Console.ReadLine());
int[,] matrix1 = new int[numberM, numberN];
System.Console.WriteLine("Your 1-st matrix is :");
FillArray(matrix1);
PrintArray(matrix1);
System.Console.WriteLine("Input Length of your 2-nd matrix, rows :");
int numberL = int.Parse(Console.ReadLine());
System.Console.WriteLine("Input Length of your 2-nd matrix, columns :");
int numberZ = int.Parse(Console.ReadLine());
int[,] matrix2 = new int[numberL, numberZ];
System.Console.WriteLine("Your 2-nd matrix is :");
FillArray(matrix2);
PrintArray(matrix2);

bool found = MultiplicationAbleMatrix(numberM, numberN, numberL, numberZ);
if (found == true)
{
    int[,] multiplicationmatrix = Multiplication(matrix1, matrix2);
    PrintArray(multiplicationmatrix);
}
else
{
    System.Console.WriteLine("You can not multiplicate your matrixes");
}