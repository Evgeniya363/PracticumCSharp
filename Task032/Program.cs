
int[] arr = InitArray(-9, 10);
PrintArray(arr);
Console.WriteLine();
ConvertArray(arr);
PrintArray(arr);

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

void ConvertArray(int[] array)
{
  for (int i = 1; i < array.Length; i++) array[i]=-array[i];
}