// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит число A в натуральную степень B.
// Console.Clear();
// Console.WriteLine("введите число A");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine("введите число B");
// int b = int.Parse(Console.ReadLine()!);
// int step = a;
// for (int i = 1; i < b; i++)
// {
//     step = step * a;
// }
// Console.WriteLine("А в степени В = " + step);

// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// Console.Clear();
// Console.Write("Ввидите число: ");
// int n = int.Parse(Console.ReadLine()!);
// int count = 0;
// while (n > 0)
// {
//     n = n / 10;
//     count++;
// }
// Console.WriteLine($"Сумма цифр в числе = {count}");

// Задача 29: Напишите программу, которая задаёт массив 
// // из 8 элементов и выводит их на экран.
// Console.Clear();
// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 32);
// Console.WriteLine($"Результат: [{string.Join(", ", array)}]");