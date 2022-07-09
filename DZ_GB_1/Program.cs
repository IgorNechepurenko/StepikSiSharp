
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

Console.WriteLine("Введи цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
n(day);
void n(int day) {
  if (day == 6 || day == 7) {
  Console.WriteLine("Цифра: " + day + " - это выходной день!");
  }
  else if (day < 1 || day > 7) {
    Console.WriteLine("Попробуй ещё раз! Нет такого дня недели");
  }
  else Console.WriteLine("Цифра: " + day + " - это рабочий день :(");
}

// CheckingTheDayOfTheWeek(day);



// Console.Write("Введи число: ");
// int anyNumber = Convert.ToInt32(Console.ReadLine());
// string anyNumberText = Convert.ToString(anyNumber);
// if (anyNumberText.Length > 2){
//   Console.WriteLine("третья цифра -> " + anyNumberText[2]);
// }
// else {
//   Console.WriteLine("-> третьей цифры нет");
// }


