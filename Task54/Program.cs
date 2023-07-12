/*  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}" + " ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] matrix)
{
    int tmp = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    tmp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = tmp;
                }
            }
        }
    }
}

Console.Write("Введите количество строк: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int b = int.Parse(Console.ReadLine());

int[,] Matr = new int [a, b];
Console.WriteLine("Неотсортированный массив:");
FillArray(Matr);
PrintArray(Matr);
Console.WriteLine("Отсортированный массив:");
SortArray(Matr);
PrintArray(Matr);