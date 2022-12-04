// Задача 37: Найдите произведение пар чисел в одномерном 
// массиве. Парой считаем первый и последний элемент, второй 
// и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6]-> 36 21

int n = 5;
int[] arr = InitArray(0, -9, 10); 
PrintArray(arr);
Multiply(arr);

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
  Console.Write("]");
}

void Multiply(int[] array)
{
  Console.Write(" -> ");
  int n = array.Length;
  for (int i = 0; i < (n+1)/2; i++) 
    if (i != (array.Length - 1)/2)
      Console.Write($"{array[i] * array[n-1-i]}  ");
    else Console.Write($"{array[i]}");
}

//string negative(int num) => (num < 0) ? $"({num})" : $"{num}";
