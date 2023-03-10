// // Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
// // из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

// // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] array = GetArray(12, -9, 9);
// Console.WriteLine($"Массив: [{String.Join("; ", array)}]");
// // Создание массива
// // 3 параметра: 1 параметр - размер массива size
// // 2 параметр: нижняя граница рандома (-9), 
// // 3 ппраметр: верхняя граница рандома (9)
// int[] GetArray(int size, int minValue, int maxValue){
//     int[] result = new int[size]; // Создание массива на size элементов (12)
//     //Если size = 12, то массив состоит из 12 нулей
//     for (int i = 0; i < result.Length; i++){ //result.Length = size
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;  // Вернули массив на size элементов, заполненный чиислами от minValue до maxValue
// }

// int sumPositive = 0; // Сумма положительных чисел
// int sumNegative = 0; // Сумма отрицательных чисел
// int size = array.Length;

// for (int i = 0; i < size; i++){
//     if(array[i] > 0){
//         // sumPositive = sumPositive + array[i]; 
//         sumPositive += array[i];
//     }else{
//         sumNegative += array[i];
//     }
// }
// Console.WriteLine($"Сумма положительных чисел: {sumPositive}, отрицательных чисел: {sumNegative}");


// // Перевернуть отрицательный числа в положительные и наоборот

// int[] InverseArray(int[] inputArray){

//     for (int i = 0; i < inputArray.Length; i++){ 
//         inputArray[i] *= (-1);
//     }
//     return inputArray;  
// }

// Console.WriteLine($"Исходный массив: [{String.Join("; ", array)}]");
// Console.WriteLine($"Перевернутый массив: [{String.Join("; ", InverseArray(array))}]");




// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// int[] array = GetArray(5, -10, 10);
// int size = array.Length;
// int number = Convert.ToInt32(Console.ReadLine());
// // int maxValue=Convert.ToInt32(Console.ReadLine());
// // int minValue=Convert.ToInt32(Console.ReadLine());
// int[] GetArray(int size, int minValue, int maxValue)
// {
// int[] result = new int[size]; // Создание массива на size элементов
// // Если size = 12, то массив состоит из 12 нулей
// for (int i = 0; i < result.Length; i++) // result.Length = size
// {
// result[i] = new Random().Next(minValue, maxValue + 1);
// }
// return result;
// }
// bool isMatch = false;
// for (int i = 0; i < size; i++)
// {
// if (number == array[i])
// {
// isMatch = true;

// break;
// }
// }
// Console.WriteLine(String.Join(";", array));
// if (isMatch==true)
// {
// Console.WriteLine("Число найдено");
// }
// else
// {
// Console.WriteLine("Число не найдено");
// }




// Вариант решения 1
// int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
// int foundNumber = new Random().Next(11); // [0;10]
// bool isFind = false;// искомое число не найдено

// for (int i = 0; i < array.Length; i++){
//     if(array[i] == foundNumber){
//         isFind = true; // Число найдено
//         break;// Останавливает цикл при нахождении искомого числа
//     }
// }

// if(isFind){//isFind == true;
//     Console.WriteLine($"Число {foundNumber} найдено");
// } else{
//      Console.WriteLine($"Число {foundNumber} не найдено");
// }





// Вариант решения 2
// int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
// int foundNumber = new Random().Next(11); // [0;10]
// string isFind = "Число не найдено";// искомое число не найдено

// for (int i = 0; i < array.Length; i++){
//     if(array[i] == foundNumber){
//         isFind = "Число найдено"; // Число найдено
//         break;// Останавливает цикл при нахождении искомого числа
//     }
// }

//  Console.WriteLine($"Число {foundNumber}: {isFind}");




// Сколько чисел находится в промежутке от 10 до 99
// int size = 123;
// int[] array = new int[size];

// int count = 0; // Кол-во чисел от 10 до 99 включительно

// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(1000); //Все числа от 0 до 999
//     if(array[i] >= 10 && array[i] <= 99){
//         count++; //Инкремент
//     }
// }

// Console.WriteLine($"Исходный массив: [{String.Join("; ", array)}]");
// Console.WriteLine($"Число элементов, входящих в диапозон [10,99]: {count}");






// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] array = numberArray(3, 100, 999);
// Console.WriteLine($"Массив: [{String.Join("; ", array)}]");

// int[] numberArray(int size, int min, int max){
//     int[] result = new int[size]; 

//     for (int i = 0; i < size; i++){ 
//         result[i] = new Random().Next(min, max + 1);
//     }
//     return result;  
// }

// int count = 0;
// int size = array.Length;

// for (int i = 0; i < size; i++){
//     if(array[i] % 2 == 0){
//         count++;
//     }
// }    
// Console.WriteLine($"Количество четных чисел в массиве: {count}");






// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] array = numberArray(4, -100, 100);
Console.WriteLine($"Массив: [{String.Join("; ", array)}]");

int[] numberArray(int size, int min, int max){
    int[] result = new int[size]; 

    for (int i = 0; i < size; i++){ 
        result[i] = new Random().Next(min, max + 1);
    }
    return result;  
}

int count = 0;
int size = array.Length;

for (int i = 0; i < size; i++){
    if(array[i] % 2 != 0){
        count += array[i];
    }
}    
Console.WriteLine($"Сумма чисел на нечетных позициях в массиве: {count}");




// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// double[] array = numberArray(5, 1, 100);
// Console.WriteLine($"Массив: [{String.Join("; ", array)}]");


// double[] numberArray(int size, int min, int max){
//     double[] result = new double[size]; 
//     Random rnd = new Random();

//     for (int i = 0; i < size; i++){ 
//         result[i] = rnd.NextDouble();
//     }
//     return result;  
// }

// int size = array.Length;

// double max = array[0];
// double min = array[0];

// for (int i = 0; i < size; i++){
//     if (array[i] > max){
//             max = array[i];
//         }
//     if (array[i] < min){
//             min = array[i];
//         }
// }
// Console.WriteLine($"Разница между максимальным и минимальным значением: {max - min}");

