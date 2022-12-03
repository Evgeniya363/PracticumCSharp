// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] a = new int[8];

Console.Write("[");
for (int i = 0; i < 8; i++)
{
  a[i] = new Random().Next(0, 2);
  Console.Write($"{a[i]}");
  if (i < 7)
    Console.Write(", ");
  else Console.Write("]");
}
