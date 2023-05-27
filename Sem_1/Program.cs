// //Задача №2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
// Console.Clear();
// int max = 0;
// int min = 0;
// Console.Write("Введите 1 число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2 число: ");
// int b = int.Parse(Console.ReadLine()!);
// if (a > b)
// {
//     max = a;
//     min = b;
// }
// else
// {
//     max = b;
//     min = a;
// }
// Console.WriteLine("max = " + max + " и " + "min = " + min);

// //Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Console.Clear();
// int max = 0;
// Console.Write("Введите 1 число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2 число: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 3 число: ");
// int c = int.Parse(Console.ReadLine()!);
// if (a > max)
// {
//     max = a;
// }
// else if (b > max)
// {
//     max = b;
// }
// if ( c > max)
// {
//     max = c;
// }
// Console.WriteLine("max = " + max);

// //Задача №6 Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);

// int Div = n % 2;

// if (Div == 0)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// //Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// int evenNumber = 2;
// if(n > 1)
// {
//     while(evenNumber <= n)
//     {
//         Console.Write(evenNumber + " ");
//         evenNumber = evenNumber + 2;
//     }
// }