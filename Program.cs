// // // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
// // //Methods

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] localArray)
// {
//     for (int i = 0; i < localArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < localArray.GetLength(1); j++)
//         {
//             Console.Write($"{localArray[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// // //Code

// Console.WriteLine("Введите количество строк:");
// int rows = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int columns = int.Parse(Console.ReadLine());
// int[,] myArray = GetArray(rows, columns, 0, 101);
// Console.WriteLine("Ваш массив:");
// PrintArray(myArray);


// //  Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// // и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] localArray)
// {
//     for (int i = 0; i < localArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < localArray.GetLength(1); j++)
//         {
//             Console.Write($"{localArray[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// void FindElement(int[,] inArray, int x, int y)
// {
//     if (x >= inArray.GetLength(0) || y >= inArray.GetLength(1) || x < 1 || y < 1)
//     {
//         Console.WriteLine("Такого элемента в массиве нет");
//     }
//     else Console.WriteLine($"Значение выбранного элемента: {inArray[x, y]}");
// }


// // //Code

// Console.WriteLine("Введите количество строк:");
// int rows = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int columns = int.Parse(Console.ReadLine());

// int[,] myArray = GetArray(rows, columns, 0, 101);
// Console.WriteLine("Ваш массив:");
// PrintArray(myArray);

// Console.WriteLine("Введите номер строки выбранного элемента:");
// int rowNumber = int.Parse(Console.ReadLine()) - 1;
// Console.WriteLine("Введите номер столбца выбранного элемента:");
// int columnNumber = int.Parse(Console.ReadLine()) - 1;
// FindElement(myArray, rowNumber, columnNumber);


// // задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// // Method


// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] localArray)
// {
//     for (int i = 0; i < localArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < localArray.GetLength(1); j++)
//         {
//             Console.Write($"{localArray[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// int[] FindColumnAverage(int[,] arr)
// {

//     int size = arr.GetLength(1);
//     int[] average = new int[size];

//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         int sum = 0;
//         for (int i = 0; i < arr.GetLength(0); i++)
//         {
//             sum = sum + arr[i, j];
//         }
//         int columnAverage = sum / arr.GetLength(0);
//         average[j] = columnAverage;
//     }
//     return average;
// }

// //Code

// Console.WriteLine("Введите количество строк:");
// int rows = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int columns = int.Parse(Console.ReadLine());
// int[,] myArray = GetArray(rows, columns, 0, 11);
// Console.WriteLine("Ваш массив:");
// PrintArray(myArray);

// Console.WriteLine("Cреднее арифметическое элементов в каждом столбце: \n{0}", String.Join("\t", FindColumnAverage(myArray)));