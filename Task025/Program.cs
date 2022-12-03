// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4-> 16
int[] a = new int[2];
int i=0;
while (i<2)
{
  a[i++]=ReadNum(i);
}
Console.Write($"{a[0]} в степени {a[1]} равно {Math.Pow(a[0],a[1])}");

int ReadNum(int num)
{
  Console.Write($"Введите {num}-е число: ");
  return Convert.ToInt32(Console.ReadLine());
}