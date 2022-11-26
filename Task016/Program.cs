// Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Write("Введите 1-е число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (Math.Pow(num1,2) == num2 || Math.Pow(num2, 2) == num1)
  Console.WriteLine("Одно из чисел является квадратом другого числа");
else
  Console.WriteLine("Ни одно из чисел не является квадратом другого числа");