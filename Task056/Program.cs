// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n,m];
InitArray(array);
PrintArray(array);
Console.WriteLine();

Console.WriteLine($"Строка с минимальной суммой эленентов: {SearchRowMinSummary(array)}");


void InitArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = new Random().Next(1,10);
    }
    Console.WriteLine();
  }  
}
void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
}


int SearchRowMinSummary(int[,] array)
{
    int rowMin = 0;
    int min = 0; // Иначе компилятор ругается
    int summ;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        summ = array[i, 0];
        for (int j = 1; j < array.GetLength(1); j++)
        {
          summ += array[i, j];
        }

        if (i == 0) min = summ; // Присваиваю начальное значение min именно здесь, т.к. первая сума по строке сформирована тольо сейчас
        else if (min > summ)
        {
          min = summ;
          rowMin = i;
        }
    }
    return rowMin;
}