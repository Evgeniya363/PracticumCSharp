// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.Write("Введите двухзначное число: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (num < 10 || num > 99)
  Console.Write("Число не является двухзначным");
else 
{
  int dig2 = num % 10;
  int dig1 = (num - dig2) / 10;
  Console.Write($"Наибольшая из цифр: {Math.Max(dig1,dig2)}");
}
 
