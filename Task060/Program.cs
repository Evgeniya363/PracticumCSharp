// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите размерность трехмерного ассива (M x N x K)");
Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите K: ");
int k = Convert.ToInt32(Console.ReadLine());

if (m * n * k > 90) Console.WriteLine("Количество элементов (M * N * K) не может превышать 90");
else
{
  int[,,] array = new int[m, n, k];
  InitArray(array);
  PrintArray(array);
}

void InitArray(int[,,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int k = 0; k < arr.GetLength(2); k++)
      {
        arr[i, j, k] = InitNewElement(arr);
      }
    }
  }  
}

void PrintArray(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.WriteLine($"{array[i, j, k]} ({i}, {j}, {k})");
      }
    }
    Console.WriteLine();
  }
}

int InitNewElement(int[,,] array)
{
  bool isUnique = false;
  int value = new Random().Next(10,100);
  while(!isUnique)
  {
    value = new Random().Next(10,100);
    foreach (int item in array)
    {
      if (item == value) isUnique = false;
      else isUnique = true;
    }
  }
  return value;
}
