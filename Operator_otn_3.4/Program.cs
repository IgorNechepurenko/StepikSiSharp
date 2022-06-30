// int a = 2;
// int b = 3;
// int result = a + b;
// Console.WriteLine(result);

// double a = 2;
// int b = 3;
// double result = a / b;
// Console.WriteLine(result);

// Напишите программу, которая произведет операцию умножения над числами
// 45 и 78 и выведет получившийся результат.

// int a = 45;
// int b = 78;
// int result = a * b;
// Console.WriteLine(result);

// int a = 45;
// int b = 78;
// Console.WriteLine(a * b);

// Console.Write(45*98);

// Напишите программу, которая попросит пользователя ввести два числа от 1 до 100.
// Выведет полученные значения (см. Output). Произведет деление данных чисел и выведет
// результат деления на экран.

// Для решения вам надо конвертировать данные, которые ввел пользователь в числовой 
// (с плавающей точкой) тип данных.

// Console.WriteLine("Введите числа в диапазоне от 1 до 100.");
// var a = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("1 число: "  + a);
// var b = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("2 число: "  + b);
// Console.WriteLine(a/b);

// Console.WriteLine("Введите числа в диапазоне от 1 до 100.");
// var a = double.Parse(Console.ReadLine());
// var b = double.Parse(Console.ReadLine());
// var res = a / b;
// Console.WriteLine($"1 число: {a}\n2 число: {b}\n{res}");

// string x = ("Введите числа в диапазоне от 1 до 100.");
// Console.WriteLine(x);
// double a = Convert.ToDouble(Console.ReadLine());
// double b = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("1 число: " +a);
// Console.WriteLine("2 число: " +b);
// Console.WriteLine(a / b);

// Напишите программу, на вход которой подаются следующие числа:  45, 56, 13, 34.
// Программа должна произвести не более 4-ёх арифметических операций над данными 
// числами так, чтобы результатом выполнения программы стало число 15. После чего
// вывести конечный результат.

// int a = 45;
// int b = 56;
// int c = 13;
// int d = 34;
// int e = ((b+d)/a+c);
// Console.WriteLine(e);

// int num = (56+34)/45+13;
// Console.WriteLine(num);

// Console.WriteLine("Введите 4 числа");
// int a = Convert.ToInt32(Console.ReadLine()); //45
// Console.WriteLine($"Первое число = {a}");
// int b = Convert.ToInt32(Console.ReadLine()); //56
// int c = Convert.ToInt32(Console.ReadLine()); //13
// int d = Convert.ToInt32(Console.ReadLine()); //34
// int e = (b+d)/a+c;
// Console.WriteLine($"Ответ будет: = {e}");

// Console.WriteLine("Введите любое число от 1 до 10:");
// string a = Console.ReadLine();
// int b = int.Parse(a);
// int c = ++b;
// Console.WriteLine($"Измененное число:{c}");

// Console.WriteLine("Введите любое число от 1 до 10:");
// int a = int.Parse(Console.ReadLine());
// a++;
// Console.WriteLine($"Измененное число:{a}");

// Console.WriteLine("Введите любое число от 1 до 10:");
// byte a = byte.Parse(Console.ReadLine());
// Console.WriteLine("Измененное число:" + ++a);

// Console.WriteLine("Введите любое число от 1 до 10:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Измененное число: {++a}");


// byte n = byte.Parse(Console.ReadLine());
// Console.Write($"Введите любое число от 1 до 10:\nИзмененное число:{++n}");

// Console.WriteLine("Введите любое число от 1 до 10:");  
// string a = Console.ReadLine();
// int b = Convert.ToInt32(a);
// Console.WriteLine("Измененное число:" + ++b);

// Напишите программу, на вход которой подаются следующие значения: "0" и "4".
// Произведите операции над значением/значениями так, чтобы результатом выполнения 
// программы стало число "-4", не забудьте вывести получившийся результат. Для решения 
// используйте операцию инкремента/декремента.

// int a = 0;
// int b = 4;
// int c = a-b;
// Console.WriteLine("Ответ будет равен = " + c);

// int a = 0;
// int b = 4;
// Console.WriteLine(a-b);

// int a = 0, b = 4;
// Console.WriteLine(--a * b);

// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// Console.WriteLine(--a*b);

// Console.WriteLine("Введите число 1:");
// int a = int.Parse(Console.WriteLine());
// Console.WriteLine("Введите число 2:");
// int b = int.Parse(Console.WriteLine());
// int result a + b;
// Console.WriteLine(a + " меньше или равно " + b + " - " + result);

// int a = 5;
// int b = 4;
// Console.WriteLine(a == b);

        // int a;
        // int b;
        // Console.WriteLine("Введите число 1:");
        // a = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Введите число 2:");
        // b = Convert.ToInt32(Console.ReadLine());
        // bool c = a <= b;
        // Console.WriteLine($"{a} меньше или равно {b} - {c}");

// Console.WriteLine("Введите число 1:");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число 2:");
// int b = int.Parse(Console.ReadLine());
// Console.Write($"{a} меньше или равно {b} - {a <= b}");

        // Console.WriteLine("Введите число 1:");
        // int a = int.Parse(Console.ReadLine());
        // Console.WriteLine("Введите число 2:");
        // int b = int.Parse(Console.ReadLine());
        // Console.WriteLine($"{a} меньше или равно {b} - {a <= b}");

// Console.WriteLine("Введите число 1:");
// var a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2:");
// var b = Convert.ToInt32(Console.ReadLine());
// bool c = a<=b;
// // Console.WriteLine("Введите число 1:");
// // Console.WriteLine("Введите число 2:"); 
// Console.WriteLine($"{a} меньше или равно {b}" + " - " + c);    
  
        //  Console.WriteLine("Введите число 1:");
        // int a = int.Parse(Console.ReadLine());
        // Console.WriteLine("Введите число 2:");
        // int b = int.Parse(Console.ReadLine());
        // bool c = a<=b;
        // if (a<=b)
        // {    Console.WriteLine($"{a} меньше или равно {b} - {c}");
        // }
        // else {Console.WriteLine("чот не то");
        // }

        // Console.WriteLine("Введите число 1:");
        // var a = Console.ReadLine();
        // Console.WriteLine("Введите число 2:");
        // var b = Console.ReadLine();
        // int a2 = Convert.ToInt32(a);
        // int b2 = Convert.ToInt32(b);
        // bool c = a2 <= b2;
        // Console.WriteLine($"{a2} меньше или равно {b2} - {c}");

 Random run = new Random();
 double x = run.Next(0, 30);
 double c = run.Next(0, 30);
 Console.WriteLine(x);
 Console.WriteLine(c);
 Console.WriteLine($"сумма двух случайных чисел: {x+c}");

 
 


       