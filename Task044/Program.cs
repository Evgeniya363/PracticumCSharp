// Задача 44: Не используя рекурсию, выведите первые N чисел 
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5-> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите N: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[] arr = new int[n];
Fibonacci(ref arr);
PrintArray(ref arr);

void Fibonacci(ref int[] array)
{
  int n = array.Length;
  if (n > 0) array[0] = 1;
  if (n > 1) array[1] = 1;
  for(int i = 2; i < n; i++)
  {
    array[i] = array[i - 1]+array[i - 2];
  }
}

void PrintArray(ref int[] matrix)
{
  for (int i = 0; i < matrix.Length; i++)
  {
    Console.Write($"{matrix[i]}  ");
  }
}