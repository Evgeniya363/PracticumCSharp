// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] arr = InitArray(0, 1, 10);
PrintArray(arr);
Console.WriteLine($"Pазница между максимальным и минимальным элементами массива равна {MaxMin(arr)}");

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

int MaxMin(int[] array)
{
  int max = array[0],
      min = max;
  for (int i = 1; i < array.Length; i++)
  {
    if (min > array[i]) min = array[i];
    if (max < array[i]) max = array[i];
  }
  return max - min;
}