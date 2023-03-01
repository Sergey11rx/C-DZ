// Вводится строчка. Необходимо проверить, являются ли все 
// все введенные символы числами

// "1234" - подходит, в строчке число 1234
// "1234Привет" - не подходит 

// var stringNumber = "_123";
// int number; // Если строчка состоит из чисел, то сюда попадает наше число
// // TryParse(строчка, out переменная, куда сохраняется результат перевода)
// bool isNumber = int.TryParse(stringNumber, out number); // True - cтрочка состоит из чисел, False - пр-т буквы, спецсимволы
// if (isNumber) // isNumber == true
// {
//     Console.WriteLine("Перевод произошел успешно,в стрчоке находились ТОЛЬКО цифры");
//     Console.WriteLine(number);
// }
// else
// {
//     Console.WriteLine("Перевод провалился: в строчке есть не только цифры");
//     Console.WriteLine(number);
// }
// // TryParse - преобразование строчки в формат числа. 
// // Если в строчке присутсвутют ТОЛЬКО цифры, то проверка на строчку проходит успешно
// // Если в строчке присутсвутют НЕ ТОЛЬКО цифры, в переменную 0

// Console.Write("Введите координату по оси Х: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату по оси Y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// // A(x; y)
// if (x > 0 && y > 0)
// {
//     Console.WriteLine("Четверть: I");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("Четверть: II");
// }

// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("Четверть: III");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("Четверть: IV");
// }
// else
// {
//     Console.WriteLine("Попаданиние на ось");
// }

// if - else if - else

// корень((х1-х2)^2 + (у1-у2)^2)

// A(x1;    y1)
// Console.Write("Введите координату точки A по оси Х: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки  A по оси Y: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// // B(x2;    y2)
// Console.Write("Введите координату точки B по оси Х: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки B по оси Y: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// // AB = √(x2 - x1)^2 + (y2 - y1)^2
// // Math.Sqrt(25) => 5
// // Math.Pow(число, степень) => Math.Pow(4, 2) => 4 возводите во 2 степень = 16
// var result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1,2));
// Console.WriteLine($"Результат: {result:f2}"); // До целого числа
// {result:fколичество_символов} - 2 знака после запятой в переменной result
// double test = 1.234;
// // Math.Round(число, количество знаков после запятой) => 1.23
// Console.WriteLine(Math.Round(test, 2)); // => 1.23
// A(x1;    y1); B(x2;    y2)
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int i = 1; // Точка начала: с 1 мы начинаем по условию
// while (i <= N)
// {
//     // Console.Write(Math.Pow(i,2) + "    ");
//     Console.Write(Math.Pow(i, 2) + "\t");
//     // Литерал: 1    2
//     // "\t" = Tab (4 пробела между элементами)
//     i++; // i = i + 1
// }
// "\n"  - new - перенос на новую строчку
// "\n" =  Console.WriteLine

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// // for(начало; условие; увеличение переменной - счетчика)
// for(int i = 1; i <= N; i++)
// {
//     Console.Write(Math.Pow(i, 2) + "\t");
// }

// Четные числа от 0 до N включительно
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// // for(начало; условие; увеличение переменной - счетчика)
// for(int i = 0; i <= N; i += 2)
// {
//     Console.Write(i + "\t");
// }

// i = i + 2




// Задача 19

// Console.Write("Введите пятизначное число: ");
// var value = Convert.ToInt32(Console.ReadLine());
// var str = value.ToString();

// if (str[0] == str[4] && str[1] == str[3]){
//     Console.WriteLine("Это число - палиндром");
// }else{
//     Console.WriteLine("Это число - не палиндром");
// }



// Задача 21

// Console.Write("Введите координату точки A по оси Х: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки  A по оси Y: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки  A по оси Z: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату точки B по оси Х: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки B по оси Y: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки  B по оси Z: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// AB = √ (x2-x1)^2 + (y2-y1)^2 + (z2-z1)^2

// var result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
// Console.WriteLine($"Результат: {result:f2}"); 

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53





// Задача 23
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// for(int i = 1; i <= N; i++)
// {
//     Console.Write(Math.Pow(i, 3) + "\t");
// }
