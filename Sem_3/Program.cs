﻿// Console.Clear();
// Console.Write("Введите номер четверти: ");
// double x = Double.Parse(Console.ReadLine()!);
// while (x < 1 || x > 4)
// {
//     Console.Write("Вы ошиблись!\nВведите номер четверти: ");
//     x = Double.Parse(Console.ReadLine()!);
// }
// if (x == 1)
//     Console.WriteLine("x > 0 && y > 0");
// else if (x == 2)
//     Console.WriteLine("x < 0 && y > 0");
// else if (x == 3)
//     Console.WriteLine("x < 0 && y < 0");
// else
//     Console.WriteLine("x > 0 && y < 0");
// Console.Clear();
// Console.Write("Введите координату X(1): ");
// double x1 = Double.Parse(Console.ReadLine()!);
// Console.Write("Введите координату Y(1): ");
// double y1 = Double.Parse(Console.ReadLine()!);
// Console.Write("Введите координату X(2): ");
// double x2 = Double.Parse(Console.ReadLine()!);
// Console.Write("Введите координату Y(2): ");
// double y2 = Double.Parse(Console.ReadLine()!);
// double S = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y2 - y1, 2));
// Console.WriteLine($"Расстояние равно {Math.Round(S, 3)}");

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// n = Math.Abs(n);
// for (int i = 1; i <= n; i++)
// 	Console.Write($"{i * i} ");

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// Console.Clear();
// Console.Write("Введите число: ");
// string number = Console.ReadLine()!;
// Console.Write($"Введи правильное число\nВведите число: ");
// 	number = Console.ReadLine()!;
// int len = number.Length;
// if (len == 5)
// {
//   if (number[0]==number[4] || number[1]==number[3])
//   {
//     Console.WriteLine($"Ваше число: {number} - палиндром.");
//   }
//   else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
// }
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Console.Clear();
// Console.Write("Введите координату X(1): ");
// double x1 = Double.Parse(Console.ReadLine()!);
// Console.Write("Введите координату Y(1): ");
// double y1 = Double.Parse(Console.ReadLine()!);
// Console.Write("Введите координату Z(1): ");
// double z1 = Double.Parse(Console.ReadLine()!);
// Console.Write("Введите координату X(2): ");
// double x2 = Double.Parse(Console.ReadLine()!);
// Console.Write("Введите координату Y(2): ");
// double y2 = Double.Parse(Console.ReadLine()!);
// Console.Write("Введите координату Z(2): ");
// double z2 = Double.Parse(Console.ReadLine()!);

// double A = x2 - x1;
// double B = y2 - y1;
// double C = z2 - z1;

// double S = Math.Sqrt(A * A + B * B + C * C);
// Console.WriteLine($"Расстояние равно {Math.Round(S, 3)}");
// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// n = Math.Abs(n);
// for (int i = 1; i <= n; i++)
// 	Console.Write($"{i * i * i} ");

// Console.Clear();
// Console.Write("Введите координату Х: ");
// double x = Double.Parse(Console.ReadLine()!);
// Console.Write("Введите координату Y: ");
// double y = Double.Parse(Console.ReadLine()!);
// if (x > 0 && y > 0)
//     Console.WriteLine("I");
// else if (x < 0 && y > 0)
//     Console.WriteLine("II");
// else if (x < 0 && y < 0)
//     Console.WriteLine("III");
// else
//     Console.WriteLine("IV");

// Console.Clear();
// Console.Write("Введите номер четверти: ");
// double x = Double.Parse(Console.ReadLine()!);
// while (x < 1 && x > 4)
// {
// 	Console.WriteLine("Вы ошиблись/nВведите номер четверти: ");
// 	x = Double.Parse(Console.ReadLine()!);
// }
// if (x == 1)
//     Console.WriteLine("x > 0 && y > 0");
// else if (x == 2)
//     Console.WriteLine("x < 0 && y > 0");
// else if (x == 3)
//     Console.WriteLine("x < 0 && y < 0");
// else
//     Console.WriteLine("x > 0 && y < 0");