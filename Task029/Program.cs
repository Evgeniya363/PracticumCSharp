// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33-> [6, 1, 33]

//Реализованы функции заполнения и вывода массива

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InitArray(ref array);
PrintArray(ref array);


void InitArray(ref int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = new Random().Next(1,10000);
  } 
}

void PrintArray(ref int[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length; i++)
  {
    Console.Write($"{arr[i]}");
    if (i < arr.Length-1) Console.Write(", ");
    else Console.WriteLine("]");
  }
}