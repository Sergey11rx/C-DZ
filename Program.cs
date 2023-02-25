// Напишите программу, которая на вход принимает число и
/*
выдаёт его квадрат (число умноженное на само себя).
Например:
4 -> 16 
-3 -> 9 
-7 -> 49
*/

/*
Console.Write("Введите число, для которого мы ищем квадрат: ");
// тип_данных имя_переменной = значение;
int number = Convert.ToInt32(Console.ReadLine()); // number = 5
// Математика :)
int result = number * number; // number * number = (number)^2
Console.WriteLine("Квадрат от числа: " + number + " равен " + result);
*/

// 1. Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

// Console.Write("Введите первое число: ");
// int firstValue = Convert.ToInt32(Console.ReadLine());
// // camelCase => firstValue, secondValue, firstNumberOfArray

// Console.Write("Введите второе число: ");
// int secondValue = Convert.ToInt32(Console.ReadLine());
// // firstValue = 25, secondValue = 5
// // Точка с запятой не ставится перед "{"
// if (firstValue == Math.Pow(secondValue, 2)) // Math.Pow(secondValue, 2) = secondValue * secondValue
// //  Math.Pow(число, степень) 
// //  Math.Pow(3, 2) => 3*3= 9
// {
//     Console.WriteLine("Чиcло " + firstValue + " является квадратом от " + secondValue); // True
// }
// else // Число не является квадратом
// {
//     Console.WriteLine("Чиcло " + firstValue + " НЕ является квадратом от " + secondValue); // True
// }

// 2
// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine()); // Ввели число N
// if (N < 0)
// {
//     Console.WriteLine("Введено отрицательное число. Умножили его на -1 :)");
//     N = N * (-1);
// }
// int negativeN = N * (-1); // N * (-1) = -N. 5 * (-1) = -5
// while (negativeN <= N) // [-N; N]
// {
//     Console.Write(negativeN + " ");
//     negativeN++; // increment: negativeN = negativeN + 1
// }



//Задача2
// Console.Write("Введите первое число: ");
// int firstValue = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondValue = Convert.ToInt32(Console.ReadLine());

// if (firstValue > secondValue) {
//     Console.WriteLine ("Число " + firstValue + " больше чем " + secondValue);
// }
// else {
//     Console.WriteLine ("Число " + secondValue + " больше чем " + firstValue);
// }





//Задача 4
// Console.Write("Введите первое число: ");
// int firstValue = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondValue = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите третье число: ");
// int thirdValue = Convert.ToInt32(Console.ReadLine());

// if (firstValue > secondValue) {
//     if (firstValue > thirdValue){
//         Console.WriteLine ("max: " + firstValue);
//     }
//     else {
//         Console.WriteLine ("max: " + thirdValue);
//     }
// }
// else if (secondValue > thirdValue){
//     Console.WriteLine ("max: " + secondValue);
// }
// else {
//     Console.WriteLine ("max: " + thirdValue);
// }




//Задача 6
// Console.Write("Введите число: ");
// int Value = Convert.ToInt32(Console.ReadLine());


// if (Value % 2 == 0) {
//      Console.WriteLine ("Четное");
// }
// else{
//     Console.WriteLine ("Нечетное");
// }




// Задача 8
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int negativeN = 1;
// while (negativeN <= N) {
//     if (negativeN % 2 == 0) {
//         Console.WriteLine(negativeN);
//     }
//     negativeN++;
// }






