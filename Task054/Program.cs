// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n,m];
InitArray(array);
PrintArray(array);
Console.WriteLine();
SortRowDescending(array);
PrintArray(array);


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
      Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
}

void SortRowDescending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
      SortedOneRow(array, i);
    }
}

void SortedOneRow(int[,] array, int row)
{
  
  for (int i = array.GetLength(1)-1; i >=0; i--)
  {
    for (int j = array.GetLength(1) - 1; j > 0; j--)
    {
      if (array[i, j] > array[i, j - 1]) 
      {
        //Console.WriteLine($"{array[i, j]} > {array[i, j - 1]}");
        (array[i, j],array[i, j - 1]) = (array[i, j - 1],array[i, j]);
      }
    }
  }
}