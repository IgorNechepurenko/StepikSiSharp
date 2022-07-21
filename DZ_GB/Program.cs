//          Определение палиндрома

// Console.WriteLine("Введите пятизначное число");
// int n = Convert.ToInt32(Console.ReadLine());
// int n1, n2, n4, n5;
// n1 = n/10000;
// n2 = (n%10000) /1000;
// n4 = (n%100) /10;
// n5 = n%10;
// if (n1==n5 && n2==n4){
//     Console.WriteLine("Число является палиндромом");
//     }
// else{
//     Console.WriteLine("Число не палиндром");
// }

//Нахождение расстояний между точками

// Console.WriteLine("Введите 6 цифр координат 2-х точек:_");
// double x, y, z, x1, y1, z1, L;
// x = Convert.ToDouble(Console.ReadLine());
// y = Convert.ToDouble(Console.ReadLine());
// z = Convert.ToDouble(Console.ReadLine());
// x1 = Convert.ToDouble(Console.ReadLine());
// y1 = Convert.ToDouble(Console.ReadLine());
// z1 = Convert.ToDouble(Console.ReadLine());
// L = Math.Sqrt((x-x1)*(x-x1)+(y-y1)*(y-y1)+(z-z1)*(z-z1));
// Console.WriteLine("Расстояние между точками =: " +L);

// Найти сумму чисел числа n

// Console.WriteLine("Введите число A: ");
// int sum = 0, n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ваше число =:"+ n);
// for (int i = 1; i <= n; i++)
// {
//     sum = sum +i;
// }
// Console.WriteLine("Сумма чисел А =:" + sum);

              // Найти факториал числа N
// Console.WriteLine("Введите число N: ");
// int sum = 1, n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ваше число ="+ n);
// for (int i = 1; i <= n; i++)
// {
//     sum = sum *i;
// }
// Console.WriteLine("Факториал числа N =" + sum);

       //Определить количество цифр в числе
// Console.WriteLine("Введите число ");
// int n = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// Console.WriteLine("Ваше число = "+ n);
// while ( n>0 )
// {
//     count++;
//     n = n/10;
// }
// Console.WriteLine("Количество цифр в чесле = " + count);

    //  Ввести в массив 8 чисел от 0 до 1

// int [] = new int [8];
// void FillAray(int[] collection)
// {
// int lenght = collection.Lengt;
// int index = 0;
//     while (index<leght)
//     {
//         collection[index] = new Random().Next(0, 2);
//         index++;
//     }
// void PrintArray(int[]col)
// {
//     int count = col.Lenght;
//     int position = 0;
//     while (position<count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }
// }
// FillAray(array);
// PrintArray(array);
   
// int[] array = new int[4];
// for (int i = 0; i < 4; i++)
// {
//     array[i] = new Random().Next(-100, 101);
// }
// Console.WriteLine("[" + string.Join(", ", array) + "]");
// for (int i = 0; i < 4; i++)
// {
//     array[i] = array[i] * (-1);
// }
// Console.WriteLine("[" + string.Join(", ", array) + "]");

// int[] array = new int[5];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }

// int[] array = new int[5];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine("[" + string.Join(", ", array) + "]");
// Console.WriteLine("Введи число: ");
// int n;
// bool log = false;
// n = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < array.Length; i++)
// {
//     if (n == array[i])
//     {
//         log = true;
//         break;
//     }
// }
// if (log)
// {
//     Console.WriteLine("yes");
// }
// else
// {
//     Console.WriteLine("no");
// }

// int n;
// Console.WriteLine("Напишите кол-во чисел: ");
// n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// Console.WriteLine("Напишите числа: ");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 0; i < array.Length / 2 + 1; i++)
// {
//     Console.WriteLine(array[i] * array[array.Length - i - 1]);
// }


// int n;
// Console.WriteLine("Напишите кол-во чисел: ");
// n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// Console.WriteLine("Напишите числа: ");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// int len;
// if (n % 2 == 0){
//     len = n / 2 - 1;
// }
// else {len = n / 2;}
// for (int i = 0; i <= len; i++)
// {
//     Console.WriteLine(array[i] * array[array.Length - i - 1]);
// }


// int a = 1;
// int b = 2;
// int c = 6;
// int d = 8;
// int e = 4;
// int max = a;
// if (a > max ) max = a;
// if (b > max ) max = b;
// if (c > max ) max = c;
// if (d > max ) max = d;
// if (e > max ) max = e;
// Console.Write("max = ");
// Console.WriteLine(max);

//                              Задача1
// int[, ] CreateMatr(int n, int m)
// {
//     int[, ] matrix = new int[n ,m];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 100);
//         }
//     }
//     return matrix;
// }


// void PrintMatr(int[, ] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// PrintMatr(CreateMatr(3, 4));

// // Решение 2

// int[, ] CreateMatr(int n, int m)
// {
//     int[, ] matrix = new int[n ,m];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = Convert.ToInt32(Console.ReadLine());
//         }
//     }
//     return matrix;
// }


// void PrintMatr(int[, ] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int n = Convert.ToInt32(Console.ReadLine());
// int m = Convert.ToInt32(Console.ReadLine());
// PrintMatr(CreateMatr(n, m));

// int[, ] CreateMatr(int n, int m)
// {
//     int[, ] matrix = new int[n ,m];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = i + j;
//         }
//     }
//     return matrix;
// }


// void PrintMatr(int[, ] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int n = Convert.ToInt32(Console.ReadLine());
// int m = Convert.ToInt32(Console.ReadLine());
// PrintMatr(CreateMatr(n, m));

//                          
//                                 Задача01

// int[, ] CreateMatr(int n, int m)
// {
//     int[, ] matrix = new int[n ,m];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 100);
//             Console.Write(matrix[i, j] + " ");
//             //matrix[i, j] = Convert.ToInt32(Console.ReadLine());
//         }
//         Console.WriteLine();
//     }
//     return matrix;
// }


// void PrintMatr(int[, ] matrix)
// {
//     Console.WriteLine();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i % 2 == 1 && j % 2 == 1)
//                 matrix[i, j] = matrix[i, j] * matrix[i, j];

//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int n = Convert.ToInt32(Console.ReadLine());
// int m = Convert.ToInt32(Console.ReadLine());
// PrintMatr(CreateMatr(n, m));

// int[, ] CreateMatr(int n, int m)
// {
//     int[, ] matrix = new int[n ,m];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 100);
//             //matrix[i, j] = Convert.ToInt32(Console.ReadLine());
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     return matrix;
// }


// void PrintMatr(int[, ] matrix)
// {
//     Console.WriteLine();
//     int DiagonSum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j)
//                 DiagonSum = DiagonSum + matrix[i, j];
//         }
//     }
//     Console.WriteLine(DiagonSum);
// }

// int n = Convert.ToInt32(Console.ReadLine());
// int m = Convert.ToInt32(Console.ReadLine());
// PrintMatr(CreateMatr(n, m));  //double?

// 47 Задача 
// int n = Convert.ToInt32(Console.ReadLine());
// int m = Convert.ToInt32(Console.ReadLine());
// double[,] a = new double[n, m];
// Random random = new Random();
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//         a[i, j] = random.NextDouble() * 100;
//         Console.Write("{0,6:F2}", a[i, j]);
//     }
//     Console.WriteLine();
// }


// 50
// int[, ] CreateMatrix(int[, ] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             int x = Convert.ToInt32(Console.ReadLine());
//             matrix[i , j] = x;
//         }
//     }
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }

//     return matrix;
// }


// void CheckMatrix(int i, int j, int[, ] matrix)
// {
//     if (i < matrix.GetLength(0) && j < matrix.GetLength(1) && i >= 0 && j >= 0)
//         Console.WriteLine(matrix[i, j]);
//     else
//         Console.WriteLine("Ты ошибся");
// }

// int[, ] matrix = new int[4, 4];
// matrix = CreateMatrix(matrix);
// Console.WriteLine("Введите координаты: ");
// int i = Convert.ToInt32(Console.ReadLine());
// int j = Convert.ToInt32(Console.ReadLine());
// CheckMatrix(i, j, matrix);

// 52
// int[, ] CreateMatrix(int[, ] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             //int x = Convert.ToInt32(Console.ReadLine());
//             int x = new Random().Next(1, 1000);
//             matrix[i , j] = x;
//         }
//     }
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }

//     return matrix;
// }


// void AvgMatrix(int[, ] matrix)
// {
//     Console.WriteLine();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         double avg = 0;
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             avg = avg + matrix[j, i];
//         }
//         Console.WriteLine(i + 1 + " столбец: " + avg/matrix.GetLength(0));
//     }
// }

// int[, ] matrix = new int[4, 4];
// matrix = CreateMatrix(matrix);
// AvgMatrix(matrix);

// Задача по семинару от статистов

// void AvgMatrix(int[, ] matrix)
// {
//     Console.WriteLine();
//     int x;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         x = matrix[0, i];
//         matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
//         matrix[matrix.GetLength(0) - 1, i] = x;
//     }
    
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }

// }

// void AvgMatrix(int[, ] matrix)
// {
//     Console.WriteLine();
//     int x;
//     if (matrix.GetLength(0) == matrix.GetLength(1))
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 if (i < j)
//                 {
//                     x = matrix[i, j];
//                     matrix[i, j] = matrix[j, i];
//                     matrix[j, i] = x;
//                 }
//             }
//         }
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write(matrix[i, j] + "\t");
//             }
//             Console.WriteLine();
//         }
//     }
//     else
//         Console.WriteLine("Такое невозможно!");

// }

//            Задача от статистов 
// void AvgMatrix(int[, ] matrix)
// {
//     Console.WriteLine();
//     int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
//     int k = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             array[k] = matrix[i, j];
//             k++;
//         }
//     }
//     for (int i = 0; i < array.Length; i++)
//     {
//         int count = 1;
//         for (int j = 0; j < array.Length; j++)
//         {
//             if(array[i] == array[j] && i != j)
//                 count++;
//         }
//         Console.WriteLine(array[i] + " встречается " + count + " раз");
//     }

// }

    //  47 Задача
// void AvgMatrix(int[, ] matrix)
// {
//     Console.WriteLine();
//     int minrow = 1000;
//     int kmin = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         int sumrow = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sumrow = sumrow + matrix[i, j];
//         }
//         if (sumrow < minrow)
//         {
//             minrow = sumrow;
//             kmin = i + 1;
//         }
//     }
//     Console.WriteLine(minrow + " " + kmin);

// }

// double[,] CreateMatr(int n, int m)
// {
//     Random random = new Random();
//     double[,] matrix = new double[n, m];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = random.NextDouble() * 100;
//         }
//     }
//     return matrix;
// }

// void PrintMatr(double[, ] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write("{0: 00.000}", matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// PrintMatr(CreateMatr(3, 4));


// int[,] CreateArrayFirst(int m, int n)
// {
//     int[,] matrix1 = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix1[i, j] = new Random().Next(1, 10);
//             Console.Write(matrix1[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
//     return matrix1;

// }
// int[,] CreateArraySecond(int m, int n)
// {
//     int[,] matrix2 = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix2[i, j] = new Random().Next(1, 10);
//             Console.Write(matrix2[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     return matrix2;
// }

// void CheckMatrix(int[,] matrix1, int[,] matrix2)
// {
//     Console.WriteLine();
//     int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
//     for (int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix1.GetLength(1); j++)
//         {
//             result[i, j] = matrix1[i, j] * matrix2[i, j];
//             Console.Write(result[i, j] + " \t");
//         }
//         Console.WriteLine();
//     }
// }

// CheckMatrix(CreateArrayFirst(4, 4), CreateArraySecond(4, 4));

// int f(int n)
// {
//     Console.Write(n + " ");
//     if (n == 1)
//         return 1;
//     return f(n + 1);
// }

// int n = 10;
// f(n);

// void f(int n)
// {
//     if (n != 0)
//     {
//         f(n - 1);
//         Console.Write(n + " ");
//     }
// }

// int n = 10;
// f(n);

// void f(int n, int m)
// {
//     if (n != (m - 1))
//     {
//         f(n - 1, m);
//         Console.Write(n + " ");
//     }
// }

// int n = 10; //вводит ползователь строку
// int m = 3; // вводит пользователь строку
// f(n, m);


// void f(int n = 10, int m = 3) // уже заранее ввели данные
// {
//     if (n != (m - 1))
//     {
//         f(n - 1, m);
//         Console.Write(n + " ");
//     }
// }

// f();



// int f(int n)
// {
//     if (n == 0)
//         return 0;
//     return f(n / 10) + n % 10;
// }
// int n = 546; //Convert.ToInt32(Console.ReadLine()); //- если пользователь сам вводит цифры

// Console.Write(f(n));

int f(int a, int b)
{
    if (b == 0)
        return 1;
    return f(a, b - 1) * a;
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.Write(f(a, b));

