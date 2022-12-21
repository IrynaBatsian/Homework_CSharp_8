// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void InputMatrix(int[,,] ThreeMatrix)
{
    int number = 0;
    for (int i = 0; i < ThreeMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < ThreeMatrix.GetLength(1); j++)
        {
          for (int k = 0; k < ThreeMatrix.GetLength(2); k++)
          {
            ThreeMatrix[i, j, k] = number++;
          Console.WriteLine($"{ThreeMatrix[i, j, k]} ({i}, {j}, {k})");
          }
          Console.WriteLine();
        }
    }
}


Console.Clear();
Console.Write("Введите размер трехмерного массива: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (coord[0] * coord[1] * coord[2] > 90)
{
  Console.Write("Неверно введен размер трехмерного массива!\nВведите размер трехмерного массива: ");
  coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,,] matrix = new int[coord[0], coord[1], coord[2]];
InputMatrix(matrix);
