// 21. Напишите программу,  которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве. A (3,6,8); B(2, 1, -7), -> 15.84

Console.Write("Введите размерность пространства: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] a = new int[n],
      b = new int[n];

Console.WriteLine("Введите координаты точки А");
InitPoint(a);
Console.WriteLine("Введите координаты точки B");
InitPoint(b);

double summ2=0;
for(int i=0; i<n; i++) summ2+=Math.Pow(b[i]-a[i],2);
Console.WriteLine($"Длина отрезка АВ = {Math.Round(Math.Sqrt(summ2),2)}");

void InitPoint(int[] array)
{
  for (int i = 0; i < n; i++)
  {
    Console.Write($"координата {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
  }
}