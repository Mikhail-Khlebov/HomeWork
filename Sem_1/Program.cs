// Задача №2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
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

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
int max = 0;
Console.Write("Введите 1 число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2 число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите 3 число: ");
int c = int.Parse(Console.ReadLine()!);
if (a > max)
{
    max = a;
}
else if (b > max)
{
    max = b;
}
if ( c > max)
{
    max = c;
}
Console.WriteLine("max = " + max);