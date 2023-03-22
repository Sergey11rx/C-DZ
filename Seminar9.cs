// Унарные операторы - 1 операнд

// Бинарные операторы -2 операнда


// Постфиксной: "после" а++

// Префиксный оператор: "перед" ++а


// int a = 1;

// int prefixIncrement = ++a * a;

// Console.WriteLine(prefixIncrement); // Наибольший приоритет

// int b = 1; 
// int postfixIncrement = b++ * b; // наименьший приоритет
// Console.WriteLine(postfixIncrement);


// Тернарный оператор 

// условие - 1 операнд ? значение для истины - 2 : значение для лжи - 3

// int dreamSalary = int.MaxValue;

// int realSalary = 50000;

// var result = realSalary < dreamSalary ? true : false;

// Console.WriteLine(result);

// int Factorial(int n)
// {
//     // Базовый случай - случай выхода из рекурсии
//     if (n == 1) return 1; // Факториал от 1 = 1
//     // Рекурсивный случай - задание рекурсии (вызов функции внутри функции)
//     return n * Factorial(n - 1);
// }

// Console.WriteLine(Factorial(4)); // 4*3*2*1 = 24

// Задача 63: Задайте значение N. 
// программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// /// <summary>
// /// Печатаем все натуральные числа в промежутке от 1 до N.
// /// </summary>
// /// <param name="start"> 1 = start</param>
// /// <param name="end"> N = end</param>
// /// <returns></returns>
// string PrintNumbers(int start, int end)
// {
//     // Базовый
//     if (start == end) return start.ToString();
//     // Рекурсивный
//     return (start + ", " + PrintNumbers(start + 1, end));
// }
// Console.WriteLine(PrintNumbers(1, N));

// Задача 67:  Напишите программу, которая будет принимать
// на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int SumNumbers(int num)
// {
//     // Базовый
//     if (num == 0) return 0; // К результату добавляется 0
//     // Рекурсивный случай
//     return (num % 10 + SumNumbers(num / 10));
// }
// Console.WriteLine(SumNumbers(number));


// Задача 69: Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите степень: ");
// int degree = Convert.ToInt32(Console.ReadLine());

// int GetPower(int number, int power)
// {
//     // Базовый случай
//     if(power == 0) return 1; // Число в 0 степнени = 1
//     if(power == 1) return number;// Число в первой степени = число
//     return (number * GetPower(number, power - 1));
// }
// Console.WriteLine($"Число {number} в степени {degree}: {GetPower(number, degree)}");





// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8

// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// string PrintNumbers(int start, int end){
//     if (start == end) return start.ToString();
//     return (start + ", " + PrintNumbers(start + 1, end));
// }
// Console.WriteLine(PrintNumbers(M, N));




// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int SumElements(int M, int N){
//     if (M == N) return N;
//     return (N += SumElements(M, N - 1));
// }
// Console.WriteLine(SumElements(M, N));



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int AckermanFunction(int M, int N)
{
    if (M == 0) return N + 1;
    if (N == 0 && M > 0) return AckermanFunction(M - 1, 1);
    return (AckermanFunction(M - 1, AckermanFunction(M, N - 1)));
}
Console.WriteLine(AckermanFunction(M, N));