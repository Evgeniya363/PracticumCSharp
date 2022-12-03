// 5) ** У нас есть график, где даны отрезок 1 -  (х1; x2) и отрезок 2 (х3, x4) 	
//Необходимо составить код, который находит их пересечение. 	
//Пересечением двух отрезка 1 и 2 могут быть  - отрезок, 
//точка или ничего 	С клавиатуры вводим х1, x2, х3, x4 и выводим 
//ответ - границы пересечений отрезков, общую точку или «не пересекаются».

int[] x = new int[4];

Console.WriteLine("Введите координаты отрезков x1, x2, x3, x4: ");
for(int i=0; i<4; i++) 
{
  Console.Write($"x{i+1} = ");
  x[i] = Convert.ToInt32(Console.ReadLine());
}

int x0,x1,x2,x3;
if (x[0]<x[1]) {x0=x[0]; x1=x[1];}
else {x1=x[0]; x0=x[1];}
if (x[2]<x[3]) {x2=x[2]; x3=x[3];}
else {x3=x[2]; x2=x[3];}

int min=0, max=0;
if (x0<=x2 && x2<=x3 && x3<=x1) {min=x2; max=x3;}
else if (x2<=x0 && x0<=x3 && x3<=x1) {min=x0; max=x3;}
else if (x2<=x0 && x0<=x1 && x1<=x3) {min=x0; max=x1;}
else if (x0<=x2 && x2<=x1 && x1<=x3) {min=x2; max=x1;}
else if (x0<=x1 && x1<x2 && x2<=x3 || x2<=x3 && x3<x0 && x0<=x1)
        {min = 1; max = -1;}
else    {Console.WriteLine("Что-то не учтено"); min = 1; max = -1;}
switch(max-min) 
{
  case 0: Console.WriteLine($"Отрезки имеют общую точку x = {min}");
          break;
  case >0:Console.WriteLine($"Границы пересечение отрезков: [{min};{max}]");
          break;
  case <0:Console.WriteLine("Отрезки не пересекаются");
          break;       
}