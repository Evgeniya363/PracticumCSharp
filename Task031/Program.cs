// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
//из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

int[] arr = InitArray(-9,10);
PrintArray(arr);
Console.WriteLine($"\nСумма отрицательных: {Summ(-1,ref arr)}");
Console.WriteLine($"Сумма положительных: {Summ(1, ref arr)}");

int[] InitArray(int left, int right)
{
  Console.Write("Введите количество элементов: ");
  int n = Convert.ToInt32(Console.ReadLine());
  int[] array = new int[n];
  for (int i = 0; i < n; i++)
    array[i] = new Random().Next(left, right);
  return array;
}

int Summ(int sign, ref int[] a)
{
  int summ = 0;
  for (int i = 0; i < 12; i++)
    if (sign==Math.Sign(a[i]))  summ+=a[i];
  return summ;
}

void PrintArray(int[] array)
{
  Console.Write($"[{array[0]}");
  for (int i = 1; i < array.Length; i++) Console.Write($", {array[i]}");
  Console.Write("]");
}