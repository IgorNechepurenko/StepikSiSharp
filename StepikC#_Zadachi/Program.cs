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

//               Блокнот

// Console.Write("Введите имя: ");
// string name = Console.ReadLine();
// Console.WriteLine("Имя ученика: " + name);

// Console.Write("Введите возраст: ");
// int age = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Возраст ученика: " + age);

// Console.Write("Введите балл по русскому языку: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите балл по математике: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите балл по информатике: ");
// int c  = Convert.ToInt32(Console.ReadLine());

// var f = (a+b+c)/3;

// Console.WriteLine("Средний балл ученика: " + f);

// Калькулятор

Console.WriteLine("Нажмите 1 если хотите выполнить сложение");
Console.WriteLine("Нажмите 2 если хотите выполнить вычитание");
Console.WriteLine("Нажмите 3 если хотите выполнить умножение");
Console.WriteLine("Нажмите 4 если хотите выполнить деление");
Console.WriteLine("Нажмите 5 если хотите найти остаток от деления");

int a = Convert.ToInt32(Console.ReadLine());
if (a==1)
{
    Console.Write("Введите слагаемое 1: ");
    int sl1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите слагаемое 2: ");
    int sl2 = Convert.ToInt32(Console.ReadLine());
    int a1 = sl1+sl2;
    Console.WriteLine("Сумма чисел = " + a1);
}
else if (a==2) 
{
    Console.Write("Введите уменьшаемое 1: ");
    int sl1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите вычитаемое 2: ");
    int sl2 = Convert.ToInt32(Console.ReadLine());
    int a1 = sl1-sl2;
    Console.WriteLine("Разность чисел = " + a1);
}
else if (a==3) 
{
    Console.Write("Введите множитель 1: ");
    int sl1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите множитель 2: ");
    int sl2 = Convert.ToInt32(Console.ReadLine());
    int a1 = sl1*sl2;
    Console.WriteLine("Произведение чисел = " + a1);
}
else if (a==4) 
{
    Console.Write("Введите делимое 1: ");
    int sl1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите делитель 2: ");
    int sl2 = Convert.ToInt32(Console.ReadLine());
    int a1 = sl1/sl2;
    Console.WriteLine("Частное чисел = " + a1);
}
else if (a==5) 
{
    Console.Write("Введите делимое 1: ");
    int sl1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите делитель 2: ");
    int sl2 = Convert.ToInt32(Console.ReadLine());
    int a1 = sl1%sl2;
    Console.WriteLine("Остаток от деления = " + a1);
}
else 
{
Console.WriteLine("Значение некорректно");
}


        
