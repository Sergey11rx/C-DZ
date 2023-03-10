// void: нет оператора return 

// тип_возр_значения имя (параметры)

// int Calculate(int a, int b, char sign) // Два числа: a, b; 3 параметр: знак(*; /;)
// {
//     int result = 0;
//     // 'для char-a', "двойные кавычки"
//     if (sign == '*')
//     {
//         result = a * b;
//     }
//     else if (sign == '+')
//     {
//         result = a + b;
//     }
//     else if (sign == '-')
//     {
//         result = a - b;
//     }
//     else
//     {
//         Console.WriteLine("Обработка искл. : такого знака нет");
//     }
//     return result;
// }
// Console.WriteLine(Calculate(1,2, '+')); // Вызов метода: имя_метода(параметры)
// Console.WriteLine(Calculate(3,2, '*'));
// Console.WriteLine(Calculate(100,35, '-'));
// Console.WriteLine(Calculate(100,35, '_'));


// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// 1. Без метода
// Console.Write("Введите число А: ");
// // limit - искомое число А
// int limit = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 1; i <= limit; i++)
// {
//     sum += i;   // sum = sum + i;

// }
// Console.WriteLine($"Cумма чисел от 1 до {limit} = {sum}");

// 2. Хардкод
// Console.Write("Введите число А: ");
// int limit = Convert.ToInt32(Console.ReadLine());
// //PascalCase - для методов, то есть, каждое новое слово начинается с большой буквы
// int GetSum(int A) // A = limit
// {
//     int sum = 0;
//     for (int i = 1; i <= A; i++)
//     {
//         sum += i;   // sum = sum + i;
//     }
//     return sum;
// }

// Console.WriteLine($"Cумма чисел от 1 до {limit} = {GetSum(limit)}");
// Console.WriteLine($"Cумма чисел от 1 до {3} = {GetSum(3)}");
// Console.WriteLine($"Cумма чисел от 1 до {4} = {GetSum(4)}");
// Console.WriteLine($"Cумма чисел от 1 до {4} = {GetSum(4)}");

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int GetCountNumber(int number)
// {
//     int count = 0; // Количество цифр в числе
//     while (number > 0)
//     {
//         count++; // count = count + 1
//         number /= 10; // number = number / 10
//     }
//     return count;
// }
// // Вызов метода

// Console.WriteLine($"Количество цифр: {GetCountNumber(num)}");

// Массив на 8 элементов, состоящий из нулей и единиц
// Метод заполняет массив, возращает - заполненный массив int[]
// // Размер массива - 8
// int[] GetBinaryArray(int size)
// {
//     int[] array = new int[size]; // Получается массив на size(8) элементов
//     // Массив состоит из 8 нулей
//     // size = array.Length
//     for (int i = 0; i < size; i++)
//     {
//         // array[i] = new Random().Next(0,2);
//         array[i] = new Random().Next(2); // [0;1]
//         // array[0] = 0, array[1] = 0, array[2] = 0
//     }
//     return array;
// }
// int[] resultArray = GetBinaryArray(8);
// double[] test = new double[10]; 
// for (int i = 0; i < resultArray.Length; i++)
// {
//     Console.Write(resultArray[i] + "\t"); 
// }
// Console.WriteLine($"Массив: [ {String.Join(", ", resultArray)} ]");




// Задача 25

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Введите число A: ");
// var value1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число B: ");
// var value2 = Convert.ToInt32(Console.ReadLine());

// int Calculate(int value1, int value2){

//     int result = 1;
//     for (int i = 0; i < value2; i++){
//         result *= value1;
//     }
//     return result;
// }

// Console.WriteLine($"Число {value1} в степени {value2} равно {Calculate(value1,value2 )}");





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.Write("Введите любое число от 10 число: ");
// var value = Convert.ToInt32(Console.ReadLine());

// int Calculate(int value){

//     int result = 0;
//     while (value > 0){
//         result += value % 10;
//         value = value / 10;
//     }
//     return result;
// }
// Console.WriteLine($"Сумма чисел равна: {Calculate(value)}");




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// int[] GetBinaryArray(int size){
//     int[] array = new int[size]; 
   
//     for (int i = 0; i < size; i++){
//         array[i] = new Random().Next(0, 1000); 
//     }
//     return array;
// }
// int[] resultArray = GetBinaryArray(8);
// double[] test = new double[10]; 
// for (int i = 0; i < resultArray.Length; i++){
//     Console.Write(resultArray[i] + "\t"); 
// }
// Console.WriteLine($"Массив: [ {String.Join(", ", resultArray)} ]");