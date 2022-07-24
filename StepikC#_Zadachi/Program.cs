// Console.WriteLine("Введи число");
// for (int a = Convert.ToInt32(Console.ReadLine()); a>0; a-- )
// Console.WriteLine("Ошибка!");

// Console.WriteLine("Введите число 1:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2:");
// int b = Convert.ToInt32(Console.ReadLine());
// // for (int i = 0; i<a; i++)
// for (int i = 0; i<a; i++, b++) // второй счётчик
// {
// //   int c = b * 2;
// //   Console.WriteLine( $"{b} * 2 = {c}");
// //   b++;
//  Console.WriteLine($"{b} * {2} = {b * 2}");
// }


// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i <=a ; i++)

//     {
//         Console.Write(i + " ");
//     }

// Блокнот

Console.Write("Введите имя: ");
string name = Console.ReadLine();
Console.WriteLine("Имя ученика: " + name);

Console.Write("Введите возраст: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Возраст ученика: " + age);

Console.Write("Введите балл по русскому языку: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите балл по математике: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите балл по информатике: ");
int c  = Convert.ToInt32(Console.ReadLine());

var f = (a+b+c)/3;

Console.WriteLine("Средний балл ученика: " + f);
