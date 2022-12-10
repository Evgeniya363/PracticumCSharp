// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите последовательность чисел, например, "
                  + "0, 7, 8, -2, -2 ");

int[] arr = (Console.ReadLine() ?? String.Empty)
        .Split( new char[] {',',' ','.'}
        ,System.StringSplitOptions.RemoveEmptyEntries)
        .Select(Int32.Parse).ToArray(); 

Console.WriteLine(CalculatePositive(arr));

int CalculatePositive(int[] arr)
{
  int count = 0;
  foreach(int item in arr)
  {
    if (item  > 0) count++;
  }
  return count;
}