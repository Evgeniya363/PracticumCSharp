// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n,m];
InitArray(array);
PrintArray(array);
Console.WriteLine();

int x = 0, y = 0;
FindMin(array, ref x, ref y);

int[,] array1 = Change(array, x, y);
PrintArray(array1);

void InitArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = new Random().Next(1,10);
    }
    Console.WriteLine();
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

int[,] Change(int[,] array, int x, int y)
{
    int[,] array1 = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < array.GetLength(1) -1 ; j++)
        {
            if (i >= x)
                if (j >= y) array1[i, j] =  array[i + 1, j + 1];
                else array1[i, j] =  array[i + 1, j];
            else if (j >= y) array1[i, j] =  array[i, j + 1];
            else array1[i, j] =  array[i, j];
        } 
    }
    return array1;
}

void FindMin(int[,] array, ref int x, ref int y)
{
    int min = array[0, 0];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j])
            { 
                x = i; 
                y = j; 
                min = array[i, j];
            }

        }
    }
}