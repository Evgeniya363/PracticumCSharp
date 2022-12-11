// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите размерность массива: ");
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
InitArray(array);
Console.WriteLine("Полученный массив: ");
PrintArray(array);

Console.WriteLine("Введите индексы элемента: ");
Console.Write("i = ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("j = ");
int j = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Search(array,i,j));


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

string Search(int[,] array, int indexI, int indexJ)
{
  if ( indexI >= 0 
     & indexI < array.GetLength(0) 
     & indexJ >= 0 
     & indexJ < array.GetLength(1))
  {
    return ($"Искомый элемент равен {array[indexI, indexJ]}");
  } 
  return ($"Искомый элемент отсутствует");                    
}