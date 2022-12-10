// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

Console.WriteLine("Введите коэффициенты для уравнений прямых\n" 
                + "вида y = k1 * x + b1, y = k2 * x + b2 ");
int k1 = EnterNumeric("k1 = ");
int b1 = EnterNumeric("b1 = ");
int k2 = EnterNumeric("k2 = ");
int b2 = EnterNumeric("b2 = ");

Console.WriteLine(IntersectionPoint(k1, b1, k2, b2));

// Method of searchinf for points of intersection of straight lines
string IntersectionPoint(int k1, int b1, int k2, int b2)
{
  if (b2 - b1 == 0 & k1 - k2 == 0) return"Прямые совпадают";
  else if (b2 - b1 == 0 | k1 - k2 == 0) 
          return "Прямые параллельны - не пересекаются";
  else 
  {
    double x = Convert.ToDouble(b2 - b1) / (k1 - k2);
    return $"Прямые пересекаются в точке ({x}, {k1*x+b1})";
  }
}

// Method for entering integer value
int EnterNumeric(string title)
{
  Console.Write(title);
  return Convert.ToInt32(Console.ReadLine());
}
