// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести
// сообщение для пользователя.

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] x = new int[n,m];
InitArray(x);
PrintArray(x);
Console.WriteLine();

if (x.GetLength(0) != x.GetLength(1))
{
    Console.WriteLine("Невозможно заменить строки");
}
else
{
    Change(x);
    PrintArray(x);
}


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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            save = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = save;
        }
    }
}