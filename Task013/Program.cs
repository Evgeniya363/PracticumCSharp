// Написать программу, принимающую на входе  
// число и показывающую на выходе 
// 3-ю цифру или сообщение, что такой цифры нет

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int numAbs = Math.Abs(num);
while(numAbs>=1000)
{
  numAbs=numAbs/10;
}
Console.WriteLine(numAbs);

if (numAbs <100)
  Console.WriteLine("Неверный ввод");
else
  Console.WriteLine($"Третья цифра: {numAbs % 10}");