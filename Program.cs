// Console.Write("Введите число, для которого мы ищем квадрат: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = number * number;

// Console.WriteLine("Квардат от числа: " + number + " Равен " + result);




// Console.Write("Введите первое число: ");
// int firstValue = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondValue = Convert.ToInt32(Console.ReadLine());

// if (firstValue == Math.Pow(secondValue, 2)) {
//     Console.WriteLine ("Число " + firstValue + " является квадратом от " + secondValue);
// }
// else {
//     Console.WriteLine ("Число " + firstValue + " НЕ является квадратом от " + secondValue);
// }




// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int negativeN = N * (-1);
// while (negativeN <= N){
//     Console.WriteLine(negativeN);
//     negativeN++;
// }




Console.Write("Введите первое число: ");
int firstValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondValue = Convert.ToInt32(Console.ReadLine());

if (firstValue > secondValue) {
    Console.WriteLine ("Число " + firstValue + " больше чем " + secondValue);
}
else {
    Console.WriteLine ("Число " + secondValue + " больше чем " + firstValue);
}