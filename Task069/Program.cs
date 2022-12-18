// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите целые числа ");
Console.Write("A = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("B = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(APowerB(a, b));

int APowerB(int a, int b)
{
  if (b == 1) return a;
  else return a * APowerB(a, b-1);
}