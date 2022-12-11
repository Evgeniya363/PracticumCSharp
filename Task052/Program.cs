// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите размерность массива: ");
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
InitArray(array);
Console.WriteLine("Исходный массив: ");
PrintArray(array);

double[] cnt = ArithmeticMeanColumns(array);

Console.WriteLine("Среднее арифметическое по столбцам: ");
Console.WriteLine(string.Join(" ", cnt));

void InitArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = new Random().Next(1,10);
    }
  }  
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]}   ");
    }
    Console.WriteLine();
  }
}

double[] ArithmeticMeanColumns(int[,] array)
{
  double[] cntColumn = new double[array.GetLength(1)];
  for (int j = 0; j < array.GetLength(1); j++)
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      cntColumn[j] = cntColumn[j] + array[i, j];
    }
    cntColumn[j] = Math.Round(cntColumn[j] / array.GetLength(0), 2);
  } 
  return cntColumn;                    
}