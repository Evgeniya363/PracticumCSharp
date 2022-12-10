// Задача 40: Напишите программу, которая принимает на вход 
// три числа и проверяет, может ли существовать треугольник с 
// сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника 
// меньше суммы двух других сторон

Console.WriteLine("Введите длины сторон треугольника: ");
int a = EnterNumeric("a = ");
int b = EnterNumeric("b = ");
int c = EnterNumeric("c = ");

if (a + b <= c | a + c <= b | b + c <= a)
  Console.WriteLine("Треугольника с такими сторонами не существует");
else
{
  double p = Convert.ToDouble(a + b + c) / 2;
  Console.WriteLine("Треугольник с такими сторонами существует, "
          + "его площадь составляет "
          + $"{Math.Round(Math.Sqrt(p*(p - a)*(p - b)*(p - c)),2)}");
}

// Method for entering integer value
int EnterNumeric(string title)
{
  Console.Write(title);
  return Convert.ToInt32(Console.ReadLine());
}