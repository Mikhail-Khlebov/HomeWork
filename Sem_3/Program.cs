// Console.Clear();
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

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите минимум 3-х значное число:");
int Value = int.Parse(Console.ReadLine()!);
	Console.Write("Число содержит менее 3-х цифр.\nВведите число:");
    Value = int.Parse(Console.ReadLine()!);
int Length = Value.ToString().Length;
if (Length >= 3 && Value > 999) 
	{
	Value = Value / 10;
	}
	int result = Value % 10;
	Console.WriteLine($"Третья цифра: {result}");