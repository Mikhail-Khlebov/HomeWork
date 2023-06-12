// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из 
// промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных 
// чисел равна 29, сумма отрицательных равна -20.

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9 , 10);
// }

// void SearchSum(int[] array)
// {
//     int sumPositive  = 0 , allSum = 0;
//     foreach (int element in array)
//     {
//         if (element > 0)
//             sumPositive += element;
//             allSum += element;
//     }
//     Console.WriteLine($"Сумма положительной числе равна: {sumPositive}");
//     Console.WriteLine($"Сумма отрецательных чисел равна: {allSum - sumPositive}");
// }

// Console.Clear();
// Console.Write("Ввидите кол-во массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// SearchSum(array);

// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-50 , 50);
// }

// void ReverseNumber(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] *= (-1);
// }

// Console.Clear();
// Console.Write("Ввидите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// ReverseNumber(array);
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");

// Задача 33: Задайте массив. Напишите программу, которая определяет,
//  присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-50 , 51);
}

string SearchNumber(int[] array, int number)
{
    foreach (int element in array)
    {
        if (element == number)
            return "yes";
    }
    return "no";
}

Console.Clear();
Console.Write("Ввидите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.Write("Ввидите число хотите найти: ");
int k = int.Parse(Console.ReadLine()!);
Console.WriteLine(SearchNumber(array, k));

// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-50 , 51);
}

int CountNumber(int[] array, int number)
{
    foreach (int element in array)
    {
        if (element >= 10 and element)
            return "yes";
    }
    return "no";
}