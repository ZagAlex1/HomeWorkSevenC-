// Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.Clear();

Random random = new Random();
int[,] array = FillArray(4, 4);
ReadArray(array);
int numberFromConsole = PutNumberFromConsole("Введите число : ");

ShowIndex(array, numberFromConsole);

int PutNumberFromConsole(string message)
{
  System.Console.Write(message);
  int numberFromConsole = Convert.ToInt32(Console.ReadLine());
  return numberFromConsole;
}


void ShowIndex(int[,] array, int numberFromConsole)
{
  if (FindNumber(array, numberFromConsole))
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        if (array[i, j] == numberFromConsole)
          System.Console.WriteLine($"Число : {numberFromConsole} найдено и стоит под индексом [{i},{j}]");
      }
    }
  }
  else
    Console.WriteLine($"Число : {numberFromConsole} не найдено");
}


bool FindNumber(int[,] array, int numberFromConsole)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] == numberFromConsole)
      {
        return true;
      }
    }
  }
  return false;
}

int[,] FillArray(int row, int column)
{
  int[,] array = new int[row, column];
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
    {
      array[i, j] = random.Next(1, 21);
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
      System.Console.Write("{0:d2} ", array[i, j]);
    }
    System.Console.WriteLine();
  }
}
