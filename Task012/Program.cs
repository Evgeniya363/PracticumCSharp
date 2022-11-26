// 12. Удалить вторую цифру трёхзначного числа

Console.Write("Введите трехзначное число: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (num < 100 || num > 999)
  Console.Write("Число не является трехзначным");
else
{
  int dig3 = num % 10;
  int dig1 = num / 100;
  Console.Write($"Удалили вторую цифру: {dig1*10 + dig3}");
}
