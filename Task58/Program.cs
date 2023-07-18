/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */


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

Console.Write("Введите количество строк в первой матрице: ");
int a1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в первой матрице: ");
int b1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк во второй матрице: ");
int a2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов во второй матрице: ");
int b2 = int.Parse(Console.ReadLine());

if (b1 != a2)
{
    Console.WriteLine("Умножение невозможно");
    return;   
}

void MultiplyMatrix (int [,] Matrix1, int [,] Matrix2)
{
    int[,] resultMatrix = new int[a1, b2];
     for (int i = 0; i < Matrix1.GetLength(0); i++)
    {            
        for (int j = 0; j < Matrix2.GetLength(1); j++)
        {                
            int sum = 0;
            for (int k = 0; k < Matrix1.GetLength(1); k++)                
            {
                sum += Matrix1[i, k] * Matrix2[k, j];                
            }
                resultMatrix[i, j] = sum;           
        }
        }
        for (int i = 0; i < Matrix1.GetLength(0); i++)        
        {
            for (int j = 0; j < Matrix2.GetLength(1); j++)            
            {
                Console.Write(resultMatrix[i, j] + " ");
            }            Console.WriteLine();
        }   
}

int[,] firstmatr = new int [a1, b1];
FillArray(firstmatr);
PrintArray(firstmatr);
Console.WriteLine();
int[,] secondmatr = new int [a1, b1];
FillArray(secondmatr);
PrintArray(secondmatr);
Console.WriteLine();
Console.WriteLine("Результат умножения: ");
Console.WriteLine();
MultiplyMatrix(firstmatr, secondmatr);