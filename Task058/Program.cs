// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.WriteLine("Расчет произведения матриц размерностью (M x N) и (N x K)");
Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите K: ");
int k = Convert.ToInt32(Console.ReadLine());

int[,] matrixA = new int[m,n];
InitArray(matrixA);
int[,] matrixB = new int[n,k];
InitArray(matrixB);
Console.WriteLine();

Console.WriteLine($"Матрица, размерностью ({m} x {n}) A[]");
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine($"Матрица, размерностью ({n} x {k}) B[]");
PrintArray(matrixB);
Console.WriteLine();

int[,] matrixC = MultiplyMatrix(matrixA, matrixB);
Console.WriteLine($"Результирующая матрица размерностью ({m} x {k}) -  C[] = A[] x B[]");
PrintArray(matrixC);


void InitArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = new Random().Next(1,10);
    }
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

int[,] MultiplyMatrix(int[,] arrayA, int[,] arrayB)
{
  int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];

  for (int i = 0; i< arrayA.GetLength(0); i++)
  {
    for (int j = 0; j < arrayB.GetLength(1); j++)
    {
      arrayC[i, j] = Calculate(arrayA, arrayB, i, j);
      //Console.WriteLine($"{i} {j}");
    }
  }
  return arrayC;
}

int Calculate(int[,] arrayA, int[,] arrayB, int i, int j)
{
  int summMultiply=0;
  for (int k = 0; k < arrayA.GetLength(1); k++)
  {

    summMultiply += arrayA[i,k] * arrayB[k,j];
  }
  return summMultiply;
}