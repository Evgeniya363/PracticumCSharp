// Задача 61: Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника

Console.Clear();
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
TrianglePascal(n);

void TrianglePascal(int n)
{
  int left = Console.WindowWidth / 2;
  int size = 4;
  int[] array = new int[n];

  for (int i = 0; i < n; i++)
  {
    for (int j = i; j>=0; j--)
    {
      if (j == i | j == 0) array[j] = 1;
      else array[j] = array[j] + array[j - 1];
      Console.SetCursorPosition(left - (int)(size * ((double)i / 2 - j)), i);
      Console.Write($"{array[j]}");
    }
  }
  Console.SetCursorPosition(1, n + 1);
}