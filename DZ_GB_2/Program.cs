
//                           # 34 
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] num = new int[size];
// FillArrayRandomnum(num);
// Console.WriteLine("В массиве: ");
// PrintArray(num);
// int count = 0;

// for (int a = 0; a < num.Length; a++)
// {
//     if (num[a] % 2 == 0)
//         count++;
// }

// Console.WriteLine($"В массиве {num.Length} чисел, {count}  чётных");

// void FillArrayRandomnum(int[] num)
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
// FillArrayRandomnum(num);
// Console.WriteLine("Массив: ");
// PrintArray(num);
// int sum = 0;

// for (int b = 0; b < num.Length; b+=2)
//     sum = sum + num[b];

//     Console.WriteLine($"Всего {num.Length} чисел, сумма элементов на нечётных позициях: {sum}");

// void FillArrayRandomnum(int[] num)
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
// FillArrayRandomnum(num);
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

// void FillArrayRandomnum(double[] num)
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

// Задача 47. Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.

// Console.Write("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] num = new double[m, n];
// FillArrayRandomnum(num);
// PrintArray(num);

// void FillArrayRandomnum(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в
// двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Console.Write("Введите строку: ");
// int a = Convert.ToInt32(Console.ReadLine())-1;
// Console.Write("Введите столбец: ");
// int b = Convert.ToInt32(Console.ReadLine())-1;
// int n = 3; 
// int m = 3; 
// Random random = new Random();
// int[,] arr = new int[n, m];
// Console.WriteLine("Исходный массив:");
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//   for (int j = 0; j < arr.GetLength(1); j++)
//   {
//     arr[i, j] = random.Next(0, 9);
//     Console.Write("{0} ", arr[i, j]);
//   }
//   Console.WriteLine(); }
//   if (a < 0 | a > arr.GetLength(0) | b < 0 | b > arr.GetLength(1))
//   {
//     Console.WriteLine("Элемент не существует");
//   }
//   else
//   {
//   Console.WriteLine("Значение элемента массива = {0}", arr[a, b]);
//   }
// Console.ReadLine();

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.

// Random random = new Random();
// int[,] arr = new int[4, 4];
// for (int i = 0; i < 4; i++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         arr[i, j] = random.Next(1, 10);
//         Console.Write(arr[i, j] + "  ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("-----------");

// for (int j = 0; j < 4; j++)
// {
//     double sum = 0;
//     for (int i = 0; i < 4; i++)
//     {
//         sum += arr[i, j];
//     }
//     Console.Write($" { sum / 4} " + "|" );
// }
// Console.ReadLine();

// # 50 -вариант с рандомом столбцов

// Random random = new Random();
// int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = random.Next(1, 10);
//         Console.Write(arr[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("---------------------------");
// Console.WriteLine(arr.GetLength(0));
// for (int j = 0; j < arr.GetLength(1); j++)
// {
//     double sum = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         sum += arr[i, j];
//     }
//     Console.Write($"{ sum / arr.GetLength(0)} ");
// }
// Console.ReadLine();


Random r = new Random();
int[,] mass = new int[4,3];
            
for (int i = 0; i < mass.GetLength(0); i++)//заполняем массив
   {
    for (int j = 0; j < mass.GetLength(1); j++)
        {
         mass[i, j] = r.Next(1, 10);
         }
 
    }
Console.WriteLine("введите вариант сортировки!\n u убывание\n v возрастание");
            
            // switch(Console.ReadLine())
            // {
            //     case "u":mass=SortUbiv(mass);
            //         break;
            //     case "v":mass=SortVozrast(mass);
            //         break;
            // }
            
        //     foreach (int a in mass)
        //     {
        //         Console.WriteLine(a);
        //     }
        //     Console.ReadKey();
            
        // }
 
        // static int[,] SortVozrast(int[,] x)
        // {
        //     int minVal = x[0,0];
        //         for (int i = 0; i < x.GetLength(0); i++)// перечисление строк
        //         {
        //             for (int j = 0; j < x.GetLength(1); j++)// перечисление символов(столбцов)
        //             {
        //                 for (int q = i; q < x.GetLength(0); q++)//перечесления строк для проверки
        //                 {
        //                     for ( int w =(q==i)?j:0; w < x.GetLength(1); w++)   // перечесление смиволов для проверки (исключаем проверенные и заменннеые символы)
        //                     {
 
        //                         if (x[i, j] > x[q, w])
        //                         {
        //                             minVal = x[q, w];
        //                             x[q, w] = x[i, j];
        //                             x[i, j] = minVal;
        //                         }
 
        //                     }
        //                 }
                        
        //             }
        //         }
            
        //         return x;
    
   