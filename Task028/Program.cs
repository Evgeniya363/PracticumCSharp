// Задача 28: Напишите программу, которая принимает 
//на вход число N и выдаёт произведение чисел от 1 до N.
Console.Write("Введите число:");
int m = Convert.ToInt32(Console.ReadLine());

int multi = 1;
for (int i = 1; i <= Math.Abs(m); i++)
{
  multi = multi * i * Math.Sign(m);
}
Console.WriteLine($"Произведение = {multi}");