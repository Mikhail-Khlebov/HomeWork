// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.
// void InputMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(1, 51);
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]}\t");
        
//         Console.WriteLine();
//     }
// }

// void ReverseMatrix(int[,] matrix)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         int temp = matrix[0, j];
//         matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
//         matrix[matrix.GetLength(0) - 1, j] = temp;
//     }
// }

// Console.Clear();
// Console.Write("Введите размер массива:");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine("\n\n");
// ReverseMatrix(matrix);
// PrintMatrix(matrix);



// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для пользователя

// void InputMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(1, 51);
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]}\t");
//         Console.WriteLine();
//     }
// }
// void ReverseMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         for(int j = i + 1; j < matrix.GetLength(1); j++)
//         {
//             (matrix[i, j], matrix[j, i]) = (matrix[j, i], matrix[i, j]);
//         }
//     }
// }

// Console.Clear();
// Console.Write("Введите размер массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// while (size[0] != size[1])
// {
//     Console.Write("Вы ошиблись!\nВведите размер массива: ");
//     size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// }
// int[,] matrix = new int[size[0], size[0]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine("\n\n");
// ReverseMatrix(matrix);
// PrintMatrix(matrix);

//Задача 57: Составить частотный словарь элементов 
//двумерного массива. Частотный словарь содержит 
//информацию о том, сколько раз встречается элемент входных данных.

void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 51);
    }
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}\t");
        Console.WriteLine();
    }
}
void ReverseMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for(int j = i + 1; j < matrix.GetLength(1); j++)
        {
            (matrix[i, j], matrix[j, i]) = (matrix[j, i], matrix[i, j]);
        }
    }
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[0]];
int[] helpArray = new int [size[0] * size[1]];
int countValues = (matrix.);
PrintMatrix(matrix);
Console.WriteLine("\n\n");
ReverseMatrix(matrix);
PrintMatrix(matrix);