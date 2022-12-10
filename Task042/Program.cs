// Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 1    

Console.Write("Введите число: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine($"Двоичное представление числа: {ConvertToBin(num)}");

string ConvertToBin(int numeric)
{
  string str =String.Empty;
  while(numeric>0)
  { 
    str =Convert.ToString(numeric % 2)+str;
    numeric /= 2;
  }
  return str;
}