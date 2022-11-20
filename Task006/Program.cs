// 6. Напишите программу, которая принимает на вход число и выдает,
// является-ли число четным

Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
if(num%2 == 0) 
    Console.WriteLine("Число является четным");
else
    Console.WriteLine("Число является нечетным");
