// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void InputMatrix(int[,] matrix) // Создаем процедуру для заполнения двумерного массива.
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
      matrix[i, j] = new Random().Next(-10, 11); // Заполнение рандомными числами от -10 до 10.
  }
}

void PrintMatrix(int[,] matrix) // Процедура для вывода двумерного массива
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
      Console.Write($"{matrix[i, j]} \t");
    Console.WriteLine();
  }
}

void ReleaseMatrix(int[,] matrix) // Прописываем алгоритм решения.
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(1) - 1; k++)
      {
        if (matrix[i, k] < matrix[i, k + 1]) // Если какой-то элемент массива меньше, чем следующий
        {
          int temp = matrix[i, k + 1]; // То мы меняем их местами.
          matrix[i, k + 1] = matrix[i, k];
          matrix[i, k] = temp;
        }
      }
    }
  }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[, ] matrix = new int[coord[0], coord[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив: ");
PrintMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix);
Console.WriteLine("Конечный массив: ");
PrintMatrix(matrix);
