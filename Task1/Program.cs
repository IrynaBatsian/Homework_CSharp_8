//  Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


int SumMatrix(int[,] matrix)
{
    int minSum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
        minSum += matrix[0, i]; // В минимум сохраняем сумму элементов первой строки.
    
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
            if (sum < minSum)
                minSum = sum;
    }
    return minSum;
}


Console.Clear();
Console.Write("Введите размеры прямоугольного массива: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (coord[0] == coord[1])
{
    Console.Write("Вы ошиблись!\nВведите размеры прямоугольного массива: ");
    coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[, ] matrix = new int[coord[0], coord[1]];
InputMatrix(matrix);
SumMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Результат: {SumMatrix(matrix)}");



