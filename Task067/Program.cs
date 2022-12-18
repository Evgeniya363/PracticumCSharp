// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число: ");
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр равна {SummaryDigit(n)}");

int SummaryDigit(int n)
{
  if (n < 10) return n;
  else return n % 10 + SummaryDigit(n / 10);
}