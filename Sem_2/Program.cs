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
Console.Clear();
Console.Write("Введите минимум 3-х значное число:");
int Value = int.Parse(Console.ReadLine()!);
	Console.Write("Число содержит менее 3-х цифр.\nВведите число:");
    Value = int.Parse(Console.ReadLine()!);
int Length = Value.ToString().Length;
if (Length >= 3) 
{
	while (Value > 999)
	{
		Value = Value / 10;
	}
	int result = Value % 10;
	Console.WriteLine($"Третья цифра: {result}");
    } 
    else 
    {
}