// Console.Clear();
// Console.Write("Ввидите 1-ое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Ввидите 2-ое число: ");
// int b = int.Parse(Console.ReadLine()!);
// if (a % b == 0)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine($"No, ostatok {a % b}");

// Console.Clear();
// Console.Write("Ввидите 1-ое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Ввидите 2-ое число: ");
// int b = int.Parse(Console.ReadLine()!);
// if (a * a == b || b * b == a)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");
// Console.Clear();
// int number = new Random().Next(10, 100); // [10; 99]
// Console.WriteLine(number);
// int n1 = number / 10;
// int n2 = number % 10;
// // 1 == 2, 1 > 2, 1 < 2
// if (n1 > n2)
//     Console.WriteLine(n1);
// else
//     Console.WriteLine(n2);
// Console.Clear();
// int number = new Random().Next(100, 1000); // [100; 999]
// Console.WriteLine(number);
// Console.WriteLine(number / 100 * 10 + number % 100);

// Console.Clear();
// Console.Write("Ввидите 3-х значное число: ");
// int n = int.Parse(Console.ReadLine()!);
// if (n < 100 || n >= 1000)
// {
//     Console.Write("Вы ввели не 3-х значное число!\nВвидите 3-х значное число: ");
//     n = int.Parse(Console.ReadLine()!);
// }

// Console.Clear();
// Console.Write("Ввидите 3-х значное число: ");
// int figure = int.Parse(Console.ReadLine()!);
// 	if (figure < 100 || figure >= 1000)
//     {
// 		int result = ( figure / 10 ) % 10;
// 		Console.WriteLine($"Вторая цифра {result}");
// 	} 
//     else 
//     {
// 		Console.WriteLine("Не трехзначное число ");
// 	}

// Console.Clear();
// Console.WriteLine("Задача 10 ");
// Console.Write("Введи трёхзначное число: ");
// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(threeDigitNumber);
// Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("Введи трёхзначное число:");
	int Value = Convert.ToInt32(Console.ReadLine());
	int Length = Value.ToString().Length;
	if (Length == 3) 
    {
		int result = ( Value/10 ) % 10;
		Console.WriteLine($"Вторая цифра этого числа {result}");
	}
    else 
    {
		Console.WriteLine("Не трехзначное число");
    }

