// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых 
// лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2]-> 0
// [10, 11, 12, 13, 14]-> 5

int[] arr = InitArray(123,1, 1000);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"Сумма двухзначных чисел равна {SummLR(arr,10,100)}");

int[] InitArray(int n,int left, int right)
{
  Console.Write("Введите количество элементов: ");
  n = (n == 0) ? Convert.ToInt32(Console.ReadLine()) : n;
  int[] array = new int[n];
  for (int i = 0; i < n; i++)
    array[i] = new Random().Next(left, right);
  return array;
}

void PrintArray(int[] array)
{
  Console.Write($"[{array[0]}");
  for (int i = 1; i < array.Length; i++) Console.Write($", {array[i]}");
  Console.Write("]");
}

int SummLR(int[] array,int left, int right)
{
  int summ = 0;
  for (int i = 0; i < array.Length; i++)
    if(array[i] >= left && array[i] <= right) summ+=array[i];
  return summ;
}