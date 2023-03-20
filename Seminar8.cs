// int rows = 3;
// int columns = 3;
// if (rows != columns) // Проверка на неравенство
// {
//     Console.WriteLine("Матрица прямоугольная");
//     return;
// }
// // 1. Заполним таблицу
// int[,] resultMatrix = GetMatrix(rows, columns, 0, 10); //3 стр, 3 стлбц, числа от 0 до 10 включительно
// // Квадратная матрица: строки = столбцы(5 = 5)
// PrintMatrix(resultMatrix);
// // 2. Печать матрицы
// Console.WriteLine("Результат: ");
// PrintMatrix(ChangeArray(resultMatrix));

// Меняем 1 и последнюю строчку местами
// Console.WriteLine("Результирующая матрица:(после VOID) ");
// ChangeRows(resultMatrix);
// PrintMatrix(resultMatrix); // Печатает матрицу с замененной 1 и последней строчкой



/// <summary>
/// Этот метод заполняет двумерный массив
/// числами от min до max (общее описание)
/// </summary>
// /// <param name="rows">Количество строк (описывается параметр)</param>
// /// <param name="cols">Количество столбцов (описывается параметр)</param>
// /// <param name="min">Минимальное число для рандома(описывается параметр)</param>
// /// <param name="max">Максимальное число для рандома(описывается параметр)</param>
// /// <returns>Заполненный двумерный массив целых чисел</returns>
// int[,] GetMatrix(int rows, int cols, int min, int max) // параметры (4)
// {
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }
/// <summary>т
/// Метод печатает матрицу, которую передали на вход
/// </summary>
// /// <param name="inputMatrix"> Двумерный массив или таблица </param>
// void PrintMatrix(int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++) // Строчки
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++) // Столбцы
//         {
//             Console.Write(inputMatrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// Методы: PascalCase (FillArray, FillMatrix)
// camelCase (firstNumber, inputMatrix)
/// <summary>
/// Метод меняет 1 и последнюю строчку местами
/// </summary>
// / <param name="matr"> матрица (двумерный массив) </param>
// void ChangeRows(int[,] matr)
// {
//     int lastRow = matr.GetLength(0) - 1; // Индекс самой последней строчки :Р
//     for (int i = 0; i < matr.GetLength(1); i++)
//     {
//         int temp = matr[0, i]; // Элемент таблицы из 0 строчки и i столбца
//         matr[0, i] = matr[lastRow, i];
//         //  Элемент из 0 строчки и i столбца = элементу из посл. строчки и i столбца
//         matr[lastRow, i] = temp; 
//         // элемент из посл. строчки и i столбца = temp = Элемент таблицы из 0 строчки и i столбца
//     }
// }

// /// <summary>
// /// Меняем строчки и столбцы местами.
// /// </summary>
// /// <param name="matrix"> Двумерный массив</param>
// /// <returns> Матрица,в которой поменяли строчки со столбцами</returns>
// int[,] ChangeArray(int[,] matrix) // параметры (4)
// {
//     int[,] copyMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
//     for (int i = 0; i < copyMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < copyMatrix.GetLength(1); j++)
//         {
//             copyMatrix[i, j] = matrix[j, i];
//         }
//     }
//     return copyMatrix;
// }


// int rows = 3;

// int cols = 3;

// int[,] matrix = new int[rows, cols];

// int min = int.MaxValue;

// int indexMinRows = 0; // Номер строчки с мин. элементом
// int indexMinCols = 0; // Номер строчки с мин. элементом

// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < cols; j++)
//     {
//         matrix[i,j] = new Random().Next(11); // 0-10
//         Console.Write(matrix[i,j] + "\t");
//         if (min > matrix[i,j])
//         {
//             min = matrix[i,j];
//             indexMinRows = i;
//             indexMinCols = j;
//         }
//     }
//     Console.WriteLine();
// }
// Console.WriteLine($"Мин.элемент: {min}, \t строчка: {indexMinRows}, \t cтолб: {indexMinCols}");

// for (int i = 0; i < rows; i++)
// {
//     if(i != indexMinRows)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             if (j != indexMinCols)
//             {
//                 Console.Write(matrix[i,j] + "\t");
//             }
//         }
//         Console.WriteLine();
//     }
// }




// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



// int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue){
//     int[,] matrix = new int [rows, columns];
//         for (int i = 0; i < matrix.GetLength(0); i++){
//             for (int j = 0; j < matrix.GetLength(1); j++){
//                 matrix[i, j] = new Random().Next(minValue, maxValue + 1);
//             }
//         }
//     return matrix;
// }


// void PermutationRows(int[,] matrix){
//     int lastRow = matrix.GetLength(0) - 1; 
//     for (int i = 0; i < matrix.GetLength(1); i++){
//         int temp = matrix[0, i]; 
//         matrix[0, i] = matrix[lastRow, i];
//         matrix[lastRow, i] = temp; 
//     }
// }


// void PrintMatrix(int[,] matrix){
//     for (int i = 0; i < matrix.GetLength(0); i++){
//         for (int j = 0; j < matrix.GetLength(1); j++){
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] resultMatrix = CreateMatrix(4, 4, 1, 10);
// PrintMatrix(resultMatrix);

// Console.WriteLine($"Упорядоченный массив: ");
// PermutationRows(resultMatrix);





// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue){
//     int[,] matrix = new int [rows, columns];
//         for (int i = 0; i < matrix.GetLength(0); i++){
//             for (int j = 0; j < matrix.GetLength(1); j++){
//                 matrix[i, j] = new Random().Next(minValue, maxValue + 1);
//             }
//         }
//     return matrix;
// }


// int[,] SumRows(int[,] inputMatrix){
//     int indexMinRows = 0;
//     int min = int.MaxValue;
//     for (int i = 0; i < inputMatrix.GetLength(0); i++){
//         int result = 0;
//         for (int j = 0; j < inputMatrix.GetLength(1); j++){
//             result += inputMatrix[i, j];
//         }
//         if(result < min){
//             min = result;
//             indexMinRows++;
//         }
//     }
//     return inputMatrix;
// }


// void PrintMatrix(int[,] matrix){
//     for (int i = 0; i < matrix.GetLength(0); i++){
//         for (int j = 0; j < matrix.GetLength(1); j++){
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] resultMatrix = CreateMatrix(4, 4, 1, 10);
// PrintMatrix(resultMatrix);

// Console.WriteLine($"Строка с наименьшей суммой элементов: ");
// SumRows(resultMatrix);




// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



// int[,] firstMatrix = new int[4, 4];
// CreateMatrix(firstMatrix);
// Console.WriteLine($"\nПервая матрица:");
// PrintMatrix(firstMatrix);

// int[,] secondMatrix = new int[4, 4];
// CreateMatrix(secondMatrix);
// Console.WriteLine($"\nВторая матрица:");
// PrintMatrix(secondMatrix);

// int[,] resultMatrix = new int[4, 4];
// SumMatrix(firstMatrix, secondMatrix, resultMatrix);
// Console.WriteLine($"\nРезультирующая матрица:");
// PrintMatrix(resultMatrix);

// void SumMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
// {
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstMatrix.GetLength(1); k++)
//       {
//         sum += firstMatrix[i,k] * secondMatrix[k,j];
//       }
//       resultMatrix[i,j] = sum;
//     }
//   }
// }


// void CreateMatrix(int[,] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       matrix[i, j] = new Random().Next(1,5);
//     }
//   }
// }

// void PrintMatrix (int[,] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       Console.Write(matrix[i,j] + "\t");
//     }
//     Console.WriteLine();
//   }
// }




// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// int[,,] CreateMatrix(int rows, int columns, int deep, int minValue, int maxValue){
//     int[,,] matrix = new int [rows, columns, deep];
//         for (int i = 0; i < matrix.GetLength(0); i++){
//             for (int j = 0; j < matrix.GetLength(1); j++){
//                 for (int k = 0; k < matrix.GetLength(2); k++){
//                     matrix[i, j, k] = new Random().Next(minValue, maxValue + 1);
//                 }
//             }
//         }
//     return matrix;
// }


// int[,,] resultMatrix = CreateMatrix(2, 2, 2, 10, 99);
// PrintMatrix(resultMatrix);


// void PrintMatrix(int[,,] matrix){
//     for (int i = 0; i < matrix.GetLength(0); i++){
//         for (int j = 0; j < matrix.GetLength(1); j++){
//             for (int k = 0; k < matrix.GetLength(2); k++){
//                 Console.Write($"{resultMatrix[i, j, k]}({i},{j},{k}) ");
//             }
//             Console.WriteLine();
//         }
//     }
// }







