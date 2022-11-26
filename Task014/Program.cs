// Напишите программу, которая будет принимать 
// на вход два числа и выводить, является ли 
// второе число кратным первому. 
// Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 

Console.WriteLine("Введите 1-е число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число:");
int num2 = Convert.ToInt32(Console.ReadLine());

int resalt = num2 % num1;
if (resalt == 0)
  Console.WriteLine($"Остаток от деления {num2}/{num1}= {resalt}");
else
  Console.WriteLine($"Число {num2} не кратно {num1}");
