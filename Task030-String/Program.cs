string str = "Светок, Боб, Жека, Игорёха, Танюхен. Толян";
string str2 = "1, 2, 5, 7";
string[] nums = str2.Split(new char[]{' ',',','.'}, System.StringSplitOptions.RemoveEmptyEntries);
foreach (var num in nums)
{
  Console.WriteLine($"Значение: {num}");
}
int[] arr = nums.Select(Int32.Parse).ToArray();
foreach (int var in arr)
{
  Console.Write($"{var}  ");
}
int[] num1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
foreach (int var in num1)
{
  Console.Write($"{var}  ");
}