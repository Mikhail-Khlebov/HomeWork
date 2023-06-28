// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// void FillArrayRandomNumbers(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите размер массива");
// int size = int.Parse(Console.ReadLine()!);;
// int[] numbers = new int[size];
// int count = 0;
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] % 2 == 0)
//     count++;
// }
// Console.WriteLine($"количество чётных чисел в массиве -> {count} ");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// Пример: [3, 7, 23, 12] -> 19
//         [-4, -6, 89, 6] -> 0

// void FillArrayRandomNumbers(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100, 101);
//     }
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// int size = 4;
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// int sumNumbersEvenIndex = 0;

// for (int i = 1; i < numbers.Length; i += 2)
// {
//     sumNumbersEvenIndex += numbers[i];
// }
// Console.Write(sumNumbersEvenIndex);

void InputArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-50, 51);
}


String SearchNumbers(int[] array, int number)
{
    foreach (int element in array)
    {
        if (element == number)
        return "yes";
    }
    return "no";
}
Console.Clear();
Console.WriteLine("Ввидите кол-во элементов: ");
int n = int.Parse(Console.ReadLine()!);
int [] array = new int[n];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join( ", ", array)}]");
Console.Write($"Ввидите чесло которое хатите найти:");
int k = int.Parse(Console.ReadLine()!);
Console.Write(SearchNumbers(array, k));