// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0

int[] arr = InitArray(0, 1, 100);
PrintArray(arr);
Console.WriteLine($"Сумма элементов на четных позициях равна {SummEven(arr)}");

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

int SummEven(int[] array)
{
  int summ = 0;
  for (int i = 1; i < array.Length; i = i + 2)
  {
   summ += array[i];
  }
  return summ;
}