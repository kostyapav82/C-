﻿// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNum = Convert.ToInt32(Console.ReadLine());
// int mod = firstNum % secondNum;
if (firstNum % secondNum == 0) // 16 % 4 = 4целых 0/4, если 34 % 5 = 6целых 4/5
{
Console.WriteLine("Кратно");
}
else
{
Console.WriteLine("Остаток " + firstNum % secondNum);
}
