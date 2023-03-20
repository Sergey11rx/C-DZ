// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// // Матрица -  таблица, размерностью m строк на n столбцов
// int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
// {
//     int[,] matrix = new int[rows, cols]; // [строчка, столбец]
//     for (int i = 0; i < rows; i++) // строчки; rows = matrix.GetLength(0)
//     {
//         // i,j,m,k - индексы
//         for (int j = 0; j < cols; j++)// столбцы; cols = matrix.GetLength(1)
//         {
//             matrix[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return matrix; // Вернули заполненную табличку
// }

// void PrintMatrix(int[,] matr) // Печатаем двумерный массив
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // проход по строчкам
//     {
//         for (int m = 0; m < matr.GetLength(1); m++) // Проход по столбцам
//         {
//             Console.Write(matr[i, m] + "\t"); // "\t" = 4 пробела или tab
//         }
//         Console.WriteLine();
//     }
// }

// // 1. Создать массив
// int[,] resultMatrix = GetMatrix(3,4,0,10);
// // 3 строчки и 4 столбца, числа от 0 до 10 включительно

// // 2. Посмотрим на нашу матрицу
// PrintMatrix(resultMatrix);


// Матрица -  таблица, размерностью m строк на n столбцов
// int[,] GetMatrix(int rows, int cols)
// {
//     int[,] matrix = new int[rows, cols]; // [строчка, столбец]
//     for (int i = 0; i < rows; i++) // строчки; rows = matrix.GetLength(0)
//     {
//         // i,j,m,k - индексы
//         for (int j = 0; j < cols; j++)// столбцы; cols = matrix.GetLength(1)
//         {
//             matrix[i, j] = i + j;
//         }
//     }
//     return matrix; // Вернули заполненную табличку
// }

// void PrintMatrix(int[,] matr) // Печатаем двумерный массив
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // проход по строчкам
//     {
//         for (int m = 0; m < matr.GetLength(1); m++) // Проход по столбцам
//         {
//             Console.Write(matr[i, m] + "\t"); // "\t" = 4 пробела или tab
//         }
//         Console.WriteLine();
//     }
// }

// // 1. Создать массив
// int[,] resultMatrix = GetMatrix(3, 4);
// // 3 строчки и 4 столбца, числа от 0 до 10 включительно

// // 2. Посмотрим на нашу матрицу
// PrintMatrix(resultMatrix);


// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, и замените 
// эти элементы на их квадраты.

// // Матрица -  таблица, размерностью m строк на n столбцов
// int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
// {
//     int[,] matrix = new int[rows, cols]; // [строчка, столбец]
//     for (int i = 0; i < rows; i++) // строчки; rows = matrix.GetLength(0)
//     {
//         // i,j,m,k - индексы
//         for (int j = 0; j < cols; j++)// столбцы; cols = matrix.GetLength(1)
//         {
//             matrix[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return matrix; // Вернули заполненную табличку
// }

// int[,] ChangeMatrix(int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++) // строчки
//     {
//         for (int k = 0; k < inputMatrix.GetLength(1); k++) // столбцы
//         {
//             if (i % 2 == 0 && k % 2 == 0) // Четные индексы
//             {
//                 inputMatrix[i, k] *= inputMatrix[i, k];
//                 // inputMatrix[i, k] = inputMatrix[i, k] * inputMatrix[i, k]
//             }
//         }
//     }
//     return inputMatrix;
// }

// void PrintMatrix(int[,] matr) // Печатаем двумерный массив
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // проход по строчкам
//     {
//         for (int m = 0; m < matr.GetLength(1); m++) // Проход по столбцам
//         {
//             Console.Write(matr[i, m] + "\t"); // "\t" = 4 пробела или tab
//         }
//         Console.WriteLine();
//     }
// }

// // 1. Создать массив
// int[,] resultMatrix = GetMatrix(3, 4, 0, 10);
// // 3 строчки и 4 столбца, числа от 0 до 10 включительно

// // 2. Посмотрим на нашу матрицу
// PrintMatrix(resultMatrix);

// Console.WriteLine("Результат: ");
// PrintMatrix(ChangeMatrix(resultMatrix));


// string CompareValue(int a, int b)
// {
//     if (a > b)
//     {
//         return "Число а больше, чем b";
//     }
//     else if (a == b)
//     {
//        return "Число а равно b";
//     }
//     return "Число а меньше, чем b";
// }

// Console.WriteLine(CompareValue(20,20));



// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// double[,] GetMatrix(int rows, int columns, int minValue, int maxValue){
//     double[,] matrix = new double[rows, columns];
//     Random rnd = new Random();
//         for (int i = 0; i < matrix.GetLength(0); i++){
//             for (int j = 0; j < matrix.GetLength(1); j++){
//             matrix[i, j] = rnd.NextDouble();
//             }
//         }
//     return matrix;
// }


// void PrintMatrix(double[,] matrix){
//     for (int i = 0; i < matrix.GetLength(0); i++){
//         for (int j = 0; j < matrix.GetLength(1); j++){
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// double[,] resultMatrix = GetMatrix(3, 4, 0, 10);
// PrintMatrix(resultMatrix);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1(строчка) 7 (столбец) -> такого числа в массиве нет

// Console.Write("Введите индекс строки: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите индекс столбца: ");
// int columns = Convert.ToInt32(Console.ReadLine());


// int[,] GetMatrix(int rows, int columns, int minValue, int maxValue){
//     int[,] matrix = new int [rows, columns];
//         for (int i = 0; i < matrix.GetLength(0); i++){
//             for (int j = 0; j < matrix.GetLength(1); j++){
//                 matrix[i, j] = new Random().Next(minValue, maxValue + 1);
//             }
//         }
//     return matrix;
// }


// int[,] FindingMatrix(int[,] inputMatrix){
//     for (int i = 0; i < inputMatrix.GetLength(0); i++){
//         for (int j = 0; j < inputMatrix.GetLength(1); j++){
//             if (rows < inputMatrix.GetLength(0) || columns < inputMatrix.GetLength(1)){
//                 Console.Write(inputMatrix[rows, columns]);
//             }else{
//                 Console.WriteLine($"{rows} строчка {columns} столбец -> такого числа в массиве нет"); 
//             } 
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

// int[,] resultMatrix = GetMatrix(5, 5, 0, 10);

// PrintMatrix(FindingMatrix(resultMatrix));


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// int[,] GetMatrix(int rows, int columns, int minValue, int maxValue){
//     int[,] matrix = new int [rows, columns];
//         for (int i = 0; i < matrix.GetLength(0); i++){
//             for (int j = 0; j < matrix.GetLength(1); j++){
//                 matrix[i, j] = new Random().Next(minValue, maxValue + 1);
//             }
//         }
//     return matrix;
// }


// int[,] AvgMatrix(int[,] inputMatrix){
//     for (int i = 0; i < inputMatrix.GetLength(0); i++){
//         int result = 0;
//         for (int j = 0; j < inputMatrix.GetLength(1); j++){
//             result += inputMatrix[i, j];
//         }
//         result /= inputMatrix.GetLength(0);
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

// int[,] resultMatrix = GetMatrix(5, 5, 1, 10);
// PrintMatrix(resultMatrix);

// Console.WriteLine($"Среднее арифметическое каждого столбца: ");
// PrintMatrix(AvgMatrix(resultMatrix));











// void PermutationRows(int[,] matrix){
//     for (int i = 0; i < matrix.GetLength(0); i++){
//         for (int j = 0; j < matrix.GetLength(1); j++){
//             for (int k = 0; k < matrix.GetLength(1) - 1; k++){
//                 if(matrix[i, k] < matrix[i, k + 1]){
//                 int temp = matrix[i, k + 1]; 
//                 matrix[i, k + 1] = matrix[i, k];
//                 matrix[i, k] = temp;
//                 } 
//             }
//         }
//     }
// }