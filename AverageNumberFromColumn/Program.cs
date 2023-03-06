// Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

Random random = new Random();
int[,] array = FillArray(4, 3);
ReadArray(array);

Average(array, 0);
Average(array, 1);
Average(array, 2);

double Sum(int[,] array, int columnNumber)
{
  int sumOfTheElements = 0;

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (j == columnNumber)
        sumOfTheElements += array[i, j];
    }
  }
  return sumOfTheElements;
}

void Average(int[,] array, int columnNumber)
{
  double sum = Sum(array, columnNumber);
  double average = sum / array.GetLength(0);
  System.Console.WriteLine($"Среднее арифметическое элементов столбца : {columnNumber} = {average}");
}


int[,] FillArray(int row, int column)
{
  int[,] array = new int[row, column];
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
    {
      array[i, j] = random.Next(1, 5);
    }
  }
  return array;
}

void ReadArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write("{0} ", array[i, j]);
    }
    System.Console.WriteLine();
  }
}