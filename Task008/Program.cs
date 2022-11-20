// 8. Написать программу, которя на вход принимает число N,
// а на выходе показывает все четные числа от 1 до N

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Способ 1 (цикл while c шагом 2): ");
int count=2;
while(count<=N)
{
  Console.Write($"{count}  ");
  count+=2;
}

Console.WriteLine();
Console.WriteLine("Способ 2 (цикл for с проверкой остатка от деления на 2): ");
for(count=1;count<=N;count++)
{
  if(count%2==0) Console.Write($"{count}  ");
}