// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] arr = InitArray(0, 100, 1000);
PrintArray(arr);
Console.WriteLine($"Количество четных элементов равно {NumEven(arr)}");

int[] InitArray(int n, int left, int right)
{
  if (n == 0)
  {
    Console.Write("Введите количество элементов: ");
    n = Convert.ToInt32(Console.ReadLine());
  }
  int[] array = new int[n];
  for (int i = 0; i < n; i++)
    array[i] = new Random().Next(left, right);
  return array;
}

void PrintArray(int[] array)
{
  Console.Write($"[{array[0]}");
  for (int i = 1; i < array.Length; i++) Console.Write($", {array[i]}");
  Console.Write("]\n");
}

int NumEven(int[] array) 
{
  int count = 0;
  for(int i = 0; i < array.Length; i++)
    if (array[i]%2 == 0) count++;
  return count;
}

