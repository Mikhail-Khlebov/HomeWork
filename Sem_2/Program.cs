// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Console.Clear();
// Console.Write("Введите трёхзначное число:");
// 	int Value = int.Parse(Console.ReadLine()!);
// 	int Length = Value.ToString().Length;
// 	if (Length == 3) 
//     {
// 		int result = ( Value/10 ) % 10;
// 		Console.WriteLine($"Вторая цифра: этого числа {result}");
// 	}
//     else 
//     {
// 		Console.WriteLine("Не трехзначное число");
//     }


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Console.Clear();
// Console.Write("Введите минимум 3-х значное число:");
// int Value = int.Parse(Console.ReadLine()!);
// 	Console.Write("Число содержит менее 3-х цифр.\nВведите число:");
//     Value = int.Parse(Console.ReadLine()!);
// int Length = Value.ToString().Length;
// if (Length >= 3 && Value > 999) 
// 	{
// 	Value = Value / 10;
// 	}
// 	int result = Value % 10;
// 	Console.WriteLine($"Третья цифра: {result}");


// // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Console.Clear();
// Console.Write("Введи цифру, обозначающую день недели: ");
// int Day = int.Parse(Console.ReadLine()!);
// Console.Write("Ввидите недельный день от 1 до 7.\nВведи цифру, обозначающую день недели: ");
//     Day = int.Parse(Console.ReadLine()!);
// if (Day >= 1 && Day <=7) 
// {
// 	if (Day >= 6) 
//     {
// 		Console.Write("Да, это выходной день!");
// 	}
//      else 
//     {
// 		Console.Write("Не выходной день!");
// 	}
// } 
