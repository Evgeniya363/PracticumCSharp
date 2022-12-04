// Задача 33: Задайте массив.Напишите программу, 
//которая определяет, присутствует ли заданное число в массиве.
// 4; массив[6, 7, 19, 345, 3]->нет
// - 3; массив[6, 7, 19, 345, 3]->да

int[] arr = InitArray(-9, 10);
PrintArray(arr);
Console.WriteLine();
Console.Write("Введите число: ");
int findItem = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {(FindItem(arr,findItem)?"":"не ")}содержится в массиве");

int[] InitArray(int left, int right)
{
  Console.Write("Введите количество элементов: ");
  int n = Convert.ToInt32(Console.ReadLine());
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

bool FindItem(int[] array, int findItem)
{
  foreach (int item in array) if (item==findItem) return true;
  return false;
}