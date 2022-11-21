// 9. Показать последнюю цифру трёхзначного числа
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 100 || num > 999) 
  Console.Write("Число не является трехзначным");
else
  Console.Write($"Последняя цифра числа: {num%10}");

