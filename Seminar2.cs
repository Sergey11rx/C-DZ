// int number = new Random().Next(10, 100);
// int firstValue = number /10; // Выведет первую цифру числа
// int secondValue = number % 10; // Выведет вторую цифру числа: 78 % 10 = 8, остаток (78-7*10 = 78-70 = 8)
// int max = firstValue // Пусть максимум - первая цифра в моем числе 78 (max = 7)

// if (secondValue > max) // 8 > 7, max = 8
// {
//     max = secondValue;
// }

// Console.WriteLine("Максимальная цифра в числе: " + number + " - это " + max)




// // 1. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
// int number = new Random().Next(100, 1000);
// int result = (number / 100) * 10 + (number % 10); // Для числа 478: (number / 100) * 10 = 4 * 10

// Console.WriteLine("Исходное число: " + number + " .1 и 3 цифра: " + result);







// Напишите программу, которая будет принимать на вход 2 числа и выводить, является ли второе число кратно первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите первое число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber % secondNumber == 0){
//     Console.WriteLine("Кратно!");
// }
// else {
//     Console.WriteLine("Не кратно, остаток от деления равен: " + firstNumber % secondNumber);
// }

// Console.WriteLine($"Не кратно, остаток от деления {firstNumber} на {secondNumber} равен: {firstNumber % secondNumber}");// интерполяция




// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// Console.Write("Введите первое число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 7 == 0 && number % 23 == 0){
//     Console.WriteLine("Кратно одновременно 7 и 23");
// }
// else {
//     Console.WriteLine("Кратно НЕ одновременно 7 и 23");
//     Console.WriteLine($"Остаток от деления равен: {number % 7}");
//     Console.WriteLine($"Остаток от деления равен: {number % 23}");
// }






// Задача 10

// int number = new Random().Next(100, 1000);
// int result = (number / 10 % 10);
// if (number >= 100 && number <= 999){
//     Console.WriteLine($"Исходное число: {number}, вторая цифра: {result}" );
// }




// Задача 13

// int number = new Random().Next(1000000, 10000000);
// int result = (number / 10000 % 10);
// int result2 = (number / 100 % 10);
// if (number >= 1000000 && number <= 9999999){
//     Console.WriteLine($"Исходное число: {number}, третья цифра слева: {result}, третья цифра справа: {result2}" );
// } else {
//     Console.WriteLine("Третьей цифры нет");
// }




Задача 15

Console.Write("Введите число, обозначающее день недели: ");
int value = Convert.ToInt32(Console.ReadLine());

if (value >= 1 && value <= 5){
    Console.WriteLine("Рабочий день");
}
if (value >= 6 && value <= 7){
    Console.WriteLine("Выходной день");
}