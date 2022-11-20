// Напишите программу, которая на входе получает 2 числа
// и выдает, какое больше, а какое меньше

Console.Write("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1>num2) 
  Console.WriteLine($"Наибольшее: {num1}, наименьшее: {num2}");
else 
  if(num2>num1) 
    Console.WriteLine($"Наибольшее из чисел: {num2}, наименьшее: {num1}");
  else 
    Console.WriteLine($"Числа равны");