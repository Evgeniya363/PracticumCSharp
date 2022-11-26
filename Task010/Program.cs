// Написать программу, принимающую на входе  
// трехзначное число и показывающую на выходе 
// 2-ю цифру

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int numAbs = Math.Abs(num);
if (numAbs<100 || numAbs>1000)
  Console.WriteLine("Неверный ввод");  
else
  Console.WriteLine($"Вторая цифра: {num%100/10}");