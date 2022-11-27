﻿// Задача 19
// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет, 12821 -> да, 23432 -> да

// Решение для 1 и более значных целых чисел 
// отрицательные числа палиндромами не являются, результат вычислений соответствующий

Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

int n = Convert.ToString(num).Length;
int[] digit = new int[n];

int i;
for (i=0; i<n; i++, num/=10) digit[i]=num%10;
for (i=0; i<n/2; i++) 
  if (digit[i]!=digit[n-1-i]) break; 
  
// при выходе из цикла по break i не достигнет значения n/2
if (i<n/2) Console.Write($"Число не является полиндромом");
else Console.Write($"Число является полиндромом");
