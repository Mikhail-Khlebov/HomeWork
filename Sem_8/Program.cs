// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// int Prompt(string message)
// {
//   Console.Write(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// int[,] CreateArray(int m, int n)
// {
//   int[,] array = new int[m, n];
//   return array;
// }

// void PrintArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
//   }
// }

// int[,] FillArrayRandom(int[,] coll)
// {
//   for (int i = 0; i < coll.GetLength(0); i++)
//   {
//     for (int j = 0; j < coll.GetLength(1); j++)
//     {
//       coll[i, j] = new Random().Next(1, 10);
//     }
//   }
//   return coll;
// }

// int[,] SortLines(int[,] matr)
// {
//   for (int i = 0; i < matr.GetLength(0); i++)
//   {
//     for (int j = 0; j < matr.GetLength(1) - 1; j++)
//     {
//       for (int k = 0; k < matr.GetLength(1) - 1; k++)
//       {
//         if (matr[i, k] < matr[i, k + 1])
//         {
//           (matr[i, k], matr[i, k + 1]) = (matr[i, k + 1], matr[i, k]);
//         }
//       }
//     }
//   }
//   return matr;
// }

// int[,] matr = CreateArray(Prompt("Введите количество строк: "), Prompt("Введите количество столбцов: "));
// matr = FillArrayRandom(matr);
// PrintArray(matr);
// Console.WriteLine();
// PrintArray(SortLines(matr));

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей
// суммой элементов: 1 строка

// int Prompt(string message)
// {
//   Console.Write(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// int[,] CreateArray(int m, int n)
// {
//   int[,] array = new int[m, n];
//   return array;
// }

// void PrintArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
//   }
// }

// int[,] FillArrayRandom(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(1, 10);
//     }
//   }
//   return array;
// }

// int SumRowArray(int[,] array)
// {
//   int[] sumArr = new int[array.GetLength(0)];
//   Console.WriteLine($"Сумма по строке:");
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       sumArr[i] += array[i, j];
//     }
//     Console.WriteLine($"{i + 1} -> {sumArr[i]}");
//   }
//   int minSum = sumArr[0];
//   int minRow = 1;
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     if (sumArr[i] < minSum)
//     {
//       minSum = sumArr[i];
//       minRow = i + 1;
//     }
//   }
//   return minRow;
// }

// int[,] array = CreateArray(Prompt("Введите количество строк: "), Prompt("Введите количество столбцов: "));
// array = FillArrayRandom(array);
// PrintArray(array);
// int row = SumRowArray(array);
// Console.WriteLine($"Наименьшая сумма в {row} строке.");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Console.Clear();
// Console.WriteLine($"Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.\n\nСразу зададим матрицу, которую можно перемножить, т.е. количество столбцов первой равно количеству строк второй");
// Console.WriteLine($"\nВведите размеры матриц и диапазон случайных значений:");
// int m = InputNumbers("Введите число строк 1-й матрицы: ");
// int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
// int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
// int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

// int[,] firstMartrix = new int[m, n];
// CreateArray(firstMartrix);
// Console.WriteLine($"\nПервая матрица:");
// WriteArray(firstMartrix);

// int[,] secomdMartrix = new int[n, p];
// CreateArray(secomdMartrix);
// Console.WriteLine($"\nВторая матрица:");
// WriteArray(secomdMartrix);

// int[,] resultMatrix = new int[m,p];

// MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
// Console.WriteLine($"\nПроизведение первой и второй матриц:");
// WriteArray(resultMatrix);

// void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
// {
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstMartrix.GetLength(1); k++)
//       {
//         sum += firstMartrix[i,k] * secomdMartrix[k,j];
//       }
//       resultMatrix[i,j] = sum;
//     }
//   }
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Console.Clear();
// Console.WriteLine($"Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
// Console.WriteLine($"\nВведите размер массива X x Y x Z:");
// int x = InputNumbers("Введите X: ");
// int y = InputNumbers("Введите Y: ");
// int z = InputNumbers("Введите Z: ");
// Console.WriteLine($"");

// int[,,] array3D = new int[x, y, z];
// CreateArray(array3D);
// WriteArray(array3D);

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void WriteArray (int[,,] array3D)
// {
//   for (int i = 0; i < array3D.GetLength(0); i++)
//   {
//     for (int j = 0; j < array3D.GetLength(1); j++)
//     {
//       Console.Write($"X({i}) Y({j}) ");
//       for (int k = 0; k < array3D.GetLength(2); k++)
//       {
//         Console.Write( $"Z({k})={array3D[i,j,k]}; ");
//       }
//       Console.WriteLine();
//     }
//     Console.WriteLine();
//   }
// }

// void CreateArray(int[,,] array3D)
// {
//   int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
//   int  number;
//   for (int i = 0; i < temp.GetLength(0); i++)
//   {
//     temp[i] = new Random().Next(10, 100);
//     number = temp[i];
//     if (i >= 1)
//     {
//       for (int j = 0; j < i; j++)
//       {
//         while (temp[i] == temp[j])
//         {
//           temp[i] = new Random().Next(10, 100);
//           j = 0;
//           number = temp[i];
//         }
//           number = temp[i];
//       }
//     }
//   }
//   int count = 0; 
//   for (int x = 0; x < array3D.GetLength(0); x++)
//   {
//     for (int y = 0; y < array3D.GetLength(1); y++)
//     {
//       for (int z = 0; z < array3D.GetLength(2); z++)
//       {
//         array3D[x, y, z] = temp[count];
//         count++;
//       }
//     }
//   }
// }

// Задача 62: Заполните спирально массив 4 на 4.
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

// Console.Clear();
// Console.WriteLine($"Задача 62: Заполните спирально массив 4 на 4.");

// int n = 4;
// int[,] sqareMatrix = new int[n, n];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
// {
//   sqareMatrix[i, j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }

// WriteArray(sqareMatrix);

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i,j] / 10 <= 0)
//       Console.Write($" {array[i,j]} ");

//       else Console.Write($"{array[i,j]} ");
//     }
//     Console.WriteLine();
//   }
// }



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
// bool CheckValue(int[] array, int number)
// {
//     foreach (int element in array)
//     {
//         if(element == number)
//             return false;
//     }
//     return true;
// }


// int InputMatrix(int[,] matrix, int[] array)
// {
//     int countNumbers = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 11); // [1; 10]
//             if (CheckValue(array, matrix[i, j]))
//             {
//                 array[countNumbers] = matrix[i, j];
//                 countNumbers++;
//             }
//         }
//     }
//     return countNumbers;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} \t");
//         Console.WriteLine();
//     }
// }

// void ReverseMatrix(int[,] matrix, int[] array, int countNumbers)
// {
//     for(int k = 0; k < countNumbers; k++)
//     {
//         int count = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 if (matrix[i, j] == array[k])
//                     count++;
//             }
//         }
//         Console.WriteLine($"Число {array[k]} встретилось ровно {count} раз");
//     }
// }

// Console.Clear();
// Console.Write("Введите размер массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// int[] helpArray = new int[size[0] * size[1]];
// int countValues = InputMatrix(matrix, helpArray);
// PrintMatrix(matrix);
// Console.WriteLine("\n\n\n");
// ReverseMatrix(matrix, helpArray, countValues);
// PrintMatrix(matrix);

// string[] array1 = new string[5] {"123", "23", "hello", "world", "res"};
// string[] array2 = new string[array1.Length];

// void SecondArrayWithIF(string[] array1, string[] array2)
// {
//     int count = 0;
//     for (int i = 0; i < array1.Length; i++)
//     {
//     if(array1[i].Length <= 3)
//         {
//         array2[count] = array1[i];
//         count++;
//         }
//     }
// }

// void PrintArray(string[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// SecondArrayWithIF(array1, array2);
// PrintArray(array2);
