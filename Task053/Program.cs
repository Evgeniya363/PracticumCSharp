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
Change(array);
PrintArray(array);

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

void Change(int[,] array)
{
    int save = 0;
    int n = array.GetLength(0) - 1 ;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        save = array[0, i];
        array[0, i] = array[n, i];
        array[n, i] = save; 
    }
}