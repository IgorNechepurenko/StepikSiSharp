
// Напишите программу, которая на вход принимает три числа,
// и выдаёт максимальное из этих чисел.

// Console.WriteLine("Введите три  числа:_");
// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// int c = int.Parse(Console.ReadLine());
// int max = a;
// if (a > max) max = a;
// if (b > max) max = b;
// if (c > max) max = c;
// Console.WriteLine("Максимальное число = " + max);

// Напишите программу, которая на вход принимает два числа, а на выходе выдаёт 
// какое число больше, а кокое меньше.
 
//  Console.WriteLine("Введите два  числа:_");
// var a = int.Parse(Console.ReadLine());
// var b = int.Parse(Console.ReadLine());
// if (a > b) Console.WriteLine("Максимальное число = " + a);
// else
// {
//    Console.WriteLine("Максимальное число = " + b); 
// }

// Напишите программу, которая на вход принимает число и выдаёт 
// является оно чётным или нет.

// Console.WriteLine("Введите число:_");
// var num = int.Parse(Console.ReadLine());
// if (num % 2==0) Console.WriteLine("Число: " +num+ "- четное");
// else Console.WriteLine("Число: " +num+ " - не четное");

// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// Console.WriteLine("Введите любое число:_");
// int N;
// N = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= N; i++){
//     if(i%2==0)
//     Console.Write(i+" ");
// }

// Напишите программу, которая на вход принимает трёхзначное
// число и на выходе показывает ВТОРУЮ цифру этого числа

// Console.WriteLine("Введите трехзначное число:_");
// int num, num2;
// num = Convert.ToInt32(Console.ReadLine());
// num2 = (num%100)/10;
// Console.WriteLine("Вторая цифра в числе: " + num +", будет: " + num2);

// Напишите программу, которая выводит ТРЕТЬЮ цифру заданного числа 
// или сообщает, что третьей цифры нет.

// Console.Write("Введи число:  ");
// // int num = Convert.ToInt32(Console.ReadLine());
// // string num1 = Convert.ToString(num);
// string num1 = Convert.ToString(Console.ReadLine());
// if (num1.Length > 2){
//   Console.Write("Третья цифра : " + num1[2]);
// }
// else {
//   Console.Write("Третьей цифры : - НЕТ");
// }

// Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.

// Console.WriteLine("Введи цифру, обозначающую день недели: ");
// int day = Convert.ToInt32(Console.ReadLine());
// n(day);
// void n(int day) {
//   if (day == 6 || day == 7) {
//   Console.WriteLine("Цифра: " + day + " - это выходной день!");
//   }
//   else if (day < 1 || day > 7) {
//     Console.WriteLine("Попробуй ещё раз! Нет такого дня недели");
//   }
//   else Console.WriteLine("Цифра: " + day + " - это рабочий день :(");
// }

// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

// Console.Write("Введи пятизначное число: ");
// string? number = Console.ReadLine();

// void num(string number){
//   if (number[0]==number[4] || number[1]==number[3]){
//     Console.WriteLine("Число: " +number + " - палиндром.");
//   }
//   else Console.WriteLine("Число: " +number + " - не палиндром.");
// }

// if (number!.Length == 5){
//   num(number);
// }
// else Console.WriteLine("Введи правильное число!");

// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.


// Console.WriteLine("Введите 6 цифр координат 2-х точек:_");
// double x, y, z, x1, y1, z1, L;
// x = Convert.ToDouble(Console.ReadLine());
// y = Convert.ToDouble(Console.ReadLine());
// z = Convert.ToDouble(Console.ReadLine());
// x1 = Convert.ToDouble(Console.ReadLine());
// y1 = Convert.ToDouble(Console.ReadLine());
// z1 = Convert.ToDouble(Console.ReadLine());
// L = Math.Sqrt((x-x1)*(x-x1)+(y-y1)*(y-y1)+(z-z1)*(z-z1));
// Console.WriteLine("Расстояние между точками= : " + L);

// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// Console.Write("Введите число: ");
// int cube = Convert.ToInt32(Console.ReadLine());

// void Cube(int[] cube){
//   int counter = 0;
//   int length = cube.Length;
//   while (counter <  length){
//     cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
//     counter++;
//   }
// }
// void PrintArry(int[] coll){
//   int count = coll.Length;
//   int index = 1;
//   while(index < count){
//     Console.Write(coll[index]+ " ");
//     index++;
//   }
// } 
// int[] arry = new int[cube+1];
// Cube(arry);
// PrintArry(arry);

//Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// Console.Write("Введите число A: ");
// int a = Convert.ToInt16(Console.ReadLine());
// Console.Write("Введите число B: ");
// int b = Convert.ToInt16(Console.ReadLine());
// int C = a;
// for (int i = 1; i < b; i++)
//      C = C * a;
// Console.WriteLine("Число: "+a+" в степени " +b+ " равно: " + C);

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Console.Write("Введите число: ");
// int i = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// while (i > 0)
// {
// int b = i % 10;
// i = i / 10;
// sum = sum + b;
// }
// Console.WriteLine($"Cумма всех цифр в числе равна: {sum}");

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int [] num = new int[8];
// Console.Write("[");

// for (int i = 0; i < num.Length; i++)
//  {
//     num [i] = new Random().Next(-99, 99);
//     Console.Write(" " + Method (i) + " ");
//  }
// Console.Write("]");

// int Method (int a)
// {
//     return num[a];
// }







