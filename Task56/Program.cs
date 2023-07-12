/* Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка */


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

void FindSum(int[,] matrix)
{
    int firstminsum = 0;
    int rownumber = 1;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            firstminsum += matrix[i, j];
        }
    }
    int min = firstminsum;
    int minrow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           sum += matrix[i, j];
        }
        if (sum < min)
        {
        min = sum;
        minrow = rownumber;        
        }
        rownumber++;
    }
    Console.WriteLine("Наименьшая сумма - это сумма ряда № " + minrow + " и равна она " + min );
}


Console.Write("Введите количество строк: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int b = int.Parse(Console.ReadLine());

int[,] Matr = new int [a, b];
FillArray(Matr);
PrintArray(Matr);
FindSum(Matr);