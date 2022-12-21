// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void InputFirstMatrix(int[,] FirstMatrix)
{
    for (int i = 0; i < FirstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < FirstMatrix.GetLength(1); j++)
        {
            FirstMatrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{FirstMatrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void InputSecondMatrix(int[,] SecondMatrix)
{
    for (int i = 0; i < SecondMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < SecondMatrix.GetLength(1); j++)
        {
            SecondMatrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{SecondMatrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


void ReleaseMatrix(int[,] FirstMatrix, int[,] SecondMatrix)
{   
    int[,] result = new int[FirstMatrix.GetLength(0), FirstMatrix.GetLength(1)];
    for (int i = 0; i < FirstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < FirstMatrix.GetLength(1); j++)
        {
            result[i, j] = FirstMatrix[i, j] * SecondMatrix[i, j];
            Console.Write($"{result[i, j]} \t");
        }
         Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры  матриц: "); // Размеры должны быть одинаковыми.
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] FirstMatrix = new int[coord[0], coord[1]];
int[,] SecondMatrix = new int[coord[0], coord[1]];
Console.WriteLine("Начальный массив 1: ");
InputFirstMatrix(FirstMatrix);
Console.WriteLine("Начальный массив 2: ");
InputSecondMatrix(SecondMatrix);
Console.WriteLine("Результат: ");
ReleaseMatrix(FirstMatrix, SecondMatrix);

