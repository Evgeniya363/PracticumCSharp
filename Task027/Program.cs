// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Вариант без использования функций
Console.Write($"Решение 1. Введите число: ");
int numeric = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int s=0;
while (numeric>0)
{
  s+=numeric%10;
  numeric/=10;
}
Console.WriteLine($"Сумма цмфр равна {s}");


// Реализация 3-мя функциями: ввод данных, создание массива цифр, подсчет суммы цифр 
int num = Math.Abs(ReadNum());
int n = (int)Math.Ceiling(Math.Log10(num)); 

int[] arr = new int[n];
DigitToArray(num, ref arr);

Console.Write($"Сумма цмфр равна {SummArray(ref arr)}");

int ReadNum()
{
  Console.Write($"Решение 2. Введите число: ");
  return Convert.ToInt32(Console.ReadLine());
}

void DigitToArray(int numeric, ref int[] array)
{
  int i=0;
  while (numeric > 0)
  {
    array[i++] = numeric % 10;
    numeric /= 10;
  }
}

int SummArray(ref int[] array)
{
  int summ=0;
  for(int i=0; i<array.Length; i++) 
    summ+=array[i];
  return summ;
}