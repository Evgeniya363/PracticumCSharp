// Задача 26: Напишите программу, которая принимает 
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число:");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int n = 0;
while(num>0)
{
 num/=10; 
 n++;
}
if (n==0) n++;
Console.WriteLine($"Количество цифр: {n}");
