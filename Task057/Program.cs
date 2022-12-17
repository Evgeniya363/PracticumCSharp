// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n,m];
InitArray(array);
PrintArray(array);
Console.WriteLine();

int[] arrayLine = ConvertArray(array);
CollectionSort(arrayLine);
Count(arrayLine);
//Change(array);
//PrintArray(array);

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

int[] ConvertArray(int[,] array)
{
  int[] arr = new int[array.Length];
  int i = 0;
  foreach(int item in array)
  {
    arr[i++] = item;
  }
  return arr;
}

void Count(int[] array)
{
    // { 2, 9, 9, 0, 2, 8, 0, 9 }
    int save = array[0]; // 2
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
       if (array[i] == save)
       {
            count++;
       }
       else
       {
            Console.WriteLine($"{save} - {count} шт.");
            save = array[i];
            count = 1;
       }
    }
    Console.WriteLine($"{save} - {count} шт.");
}

void CollectionSort(int[] array)
{
  for (int i=0; i<array.Length-1; i++)
  {
    int minPosition=i;
    for (int j=i+1; j<array.Length; j++)
    {
      if (array[j]< array[minPosition]) minPosition=j;
    }
        if (i!=minPosition)
    {
      int tmp=array[i];
      array[i]=array[minPosition];
      array[minPosition]=tmp;
    }
  }
}