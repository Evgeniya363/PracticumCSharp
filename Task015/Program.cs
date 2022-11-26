// 15. Напишите программу,которая принимает на вход цифру, обозначающую номер недели. 
// и выясняет является ли номер дня недели выходным                      

Console.Write("Введите номер дня недели в диапозоне от 1 до 7: ");
int weekNum = Convert.ToInt32(Console.ReadLine());

if (weekNum < 1 || weekNum > 7)
  Console.WriteLine($"Число {weekNum} не соответствует номеру дня недели");
else
{
  if (weekNum > 5)
    Console.WriteLine("Поздравляю, это выходной!");
  else
    Console.WriteLine("Это обычный рабочий день");
}