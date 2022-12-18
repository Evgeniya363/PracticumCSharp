//  65.

Console.WriteLine("Введите целые числа ");
Console.Write("M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("N = ");
int n = Convert.ToInt32(Console.ReadLine());
NaturalDiap(m, n);

void NaturalDiap(int m, int n)
{
  if (m > n) return;
  else 
  { 
    Console.Write($"{m} ");
    NaturalDiap(m + 1, n);
  }
}