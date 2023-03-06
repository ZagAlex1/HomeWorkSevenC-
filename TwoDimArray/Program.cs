// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

Random random = new Random();

double [,] array = FillArray(4,4);
ReadArray(array);

double[,] FillArray(int row, int column)
{
  double[,] array = new double[row, column];
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
    {
      array[i, j] = random.NextDouble()* 100 - 50;
    }
  }
  return array;
}

void ReadArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write("{0:f2} ", array[i, j]);
    }
    System.Console.WriteLine();
  }
}