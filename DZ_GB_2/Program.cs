
//                           # 34 
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] num = new int[size];
// FillArrayRandomNumbers(num);
// Console.WriteLine("В массиве: ");
// PrintArray(num);
// int count = 0;

// for (int a = 0; a < num.Length; a++)
// {
//     if (num[a] % 2 == 0)
//         count++;
// }

// Console.WriteLine($"В массиве {num.Length} чисел, {count}  чётных");

// void FillArrayRandomNumbers(int[] num)
// {
//     for(int i = 0; i < num.Length; i++)
//     {
//         num[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] num)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < num.Length; i++)
//     {
//         Console.Write(num[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

                        //  # 36
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// Console.Write("Введите размер массива_");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] num = new int[a];
// FillArrayRandomNumbers(num);
// Console.WriteLine("Массив: ");
// PrintArray(num);
// int sum = 0;

// for (int b = 0; b < num.Length; b+=2)
//     sum = sum + num[b];

//     Console.WriteLine($"Всего {num.Length} чисел, сумма элементов на нечётных позициях: {sum}");

// void FillArrayRandomNumbers(int[] num)
// {
//     for(int i = 0; i < num.Length; i++)
//         {
//             num[i] = new Random().Next(1,100);
//         }
// }
// void PrintArray(int[] num)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < num.Length; i++)
//         {
//             Console.Write(num[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }

//                               # 38
// Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.


// Console.WriteLine("Введите размер массива: ");
// int a = Convert.ToInt32(Console.ReadLine());
// double[] num = new double[a];
// FillArrayRandomNumbers(num);
// Console.WriteLine("Массив: ");
// PrintArray(num);
// double min = Int32.MaxValue;
// double max = Int32.MinValue;

// for (int b = 0; b < num.Length; b++)
// {
//     if (num[b] > max)
//         {
//             max = num[b];
//         }
//     if (num[b] < min)
//         {
//             min = num[b];
//         }
// }

// Console.WriteLine($"Всего {num.Length} чисел.");
// Console.WriteLine($"Максимальное значение: {max}, минимальное значение: {min}");
// Console.WriteLine($"Разница между {max} и {min}, составляет: {max - min}");

// void FillArrayRandomNumbers(double[] num)
// {
//     for(int i = 0; i < num.Length; i++)
//         {
//             num[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
//         }
// }
// void PrintArray(double[] num)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < num.Length; i++)
//         {
//             Console.Write(num[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }


//                          41
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
// чисел больше 0 ввёл пользователь.

// Console.Write("Введите несколько чисел: ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;
 
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0) 
//         count++;
// }
// Console.WriteLine($"Количество чисел больше нуля: {count}");

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
//пользователем. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

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
