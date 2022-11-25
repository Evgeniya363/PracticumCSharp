// 9. Показать третью слева цифру числа 
// или сообщить, что такой нет
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num/100 == 0)
  Console.Write("Третья слева цифра отсутствует");
else
{
  while( num >= 1000 || num <= -1000)
  {
    num = num / 10;
  }
  Console.Write($"Третья слева цифра: {num % 10}");
}  
