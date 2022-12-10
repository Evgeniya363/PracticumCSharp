// Задача 39: Напишите программу, которая перевернёт одномерный 
// массив (последний элемент будет на первом месте, а первый - 
// на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] arr = InitArray(0, 1, 10);
PrintArray(arr);
ConvertArray(arr);
PrintArray(arr);

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
  for (int i = 0; i < array.Length; i++) Console.Write($", {array[i]}");
  Console.Write("]\n");
}

void ConvertArray(int[] array)
{
  int n = array.Length;
  for(int i = 0; i < n/2; i++)
  {
    int tmp = array[i];
    array[i] = array[n-i-1];
    array[n-i-1] = tmp;
  }
}
