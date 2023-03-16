// // Задача 39: Напишите программу, 
// // которая перевернёт одномерный массив (последний элемент 
// // будет на первом месте, а первый - на последнем и т.д.)
// // [1 2 3 4 5] -> [5 4 3 2 1]
// // [6 7 3 6] -> [6 3 7 6]
// // Pascal Case: FillArray, GetArray (методы)
// // camelCase: firstNumber
// int[] array = FillArray(10, 0, 10); // Массив на 10 элементов,
// // заполненный рандомными числами от 0 до 10 включительно
// // Console.WriteLine($"Текст:{переменная} текст");
// Console.WriteLine($"Исходный массив:  [{String.Join("; ", array)}]");
// // FillArray: размер, мин, макс
// int[] FillArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }
// // Запись массива в обратном порядке в новый массив
// int[] resultArray = CopyArray(array);
// Console.WriteLine("Переворот через не VOID");
// Console.WriteLine($"Перевернутый массив:  [{String.Join("; ", resultArray)}]");
// int[] CopyArray(int[] inputArray)
// {
//     int size = inputArray.Length;
//     int j = size - 1; // Индекс последнего элемента
//     int[] inverseArray = new int[size]; // Массив на size элементов, заполне нулями
//     for (int i = 0;  i < size; i++, j--)
//     {
//         // inverseArray[i] = inputArray[size - 1 - i];
//         inverseArray[i] = inputArray[j];
//     }
//     return inverseArray;
// }

// // С помощью доп. переменной
// void ReverseArray(int[] arr)
// {
//     // a = {10,20,30,40,50}
//     int j = arr.Length - 1;
//     for (int i = 0; i < arr.Length / 2; i++, j--)
//     {
//         int temp = arr[i]; // temp = arr[0] = 10
//         arr[i] = arr[j]; // a[0] = a[5 - 1 - 0] 
//         // a = {50,20,30,40,50}
//         arr[j] = temp;
//         // a = {50,20,30,40,temp}, a = {50,20,30,40,10}
//     }
// }
// Console.WriteLine("Переворот через метод VOID");
// ReverseArray(array); // Здесь массив исходный с именем array перевернулся
// Console.WriteLine($"Перевернутый массив:  [{String.Join("; ", array)}]");


// int a = 35;

// int b = 4;

// int c = 5;

// bool IsTrinagle(int a, int b, int c)
// {
//     return (a + b > c && a + c > b && b + c > a); 
//     // False - треугольник не существует, True - существует
// }

// Console.WriteLine(IsTrinagle(a,b,c));

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// int countFibonacci = 5;
// int firstFibonacci = 0;     // Первое число Фибоначчи
// int secondFibonacci = 1;    // Второе число Фибоначчи

// Console.WriteLine($"1. {firstFibonacci}");  // i = 1
// Console.WriteLine($"2. {secondFibonacci}"); // i = 2

// for (int i = 3; i <= countFibonacci; i++)
// {
//     int nextFibonacci = firstFibonacci + secondFibonacci;
//     Console.WriteLine($"{i}. {nextFibonacci}");
//     firstFibonacci = secondFibonacci;
//     secondFibonacci = nextFibonacci;
// } 





// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


// Console.Write("Введите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;
 
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0)
//     {
//         count++;
//     }
// }
 
// Console.WriteLine($"Кол-во элементов больше 0: {count}");




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Console.Write("Введите k1: ");
// var k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b1: ");
// var b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k2: ");
// var k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b2: ");
// var b2 = Convert.ToDouble(Console.ReadLine());
 
 
// var x = -(b1 - b2) / (k1 - k2);
// var y = k1 * x + b1;
 
// x = Math.Round(x, 3);
// y = Math.Round(y, 3);
 
// Console.WriteLine($"Пересечение в точке: ({x};{y})");
