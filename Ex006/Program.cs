﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.Clear();
Console.WriteLine("Input number:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ((a % 2) == 0);
