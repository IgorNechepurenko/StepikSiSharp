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


int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;
int max = a;
if (a > max ) max = a;
if (b > max ) max = b;
if (c > max ) max = c;
if (d > max ) max = d;
if (e > max ) max = e;
Console.Write("max = ");
Console.WriteLine(max);