// Создайте переменную с типом char, присвойте в нее следующее значение: "$",
//  после этого выведите данную переменную.

// char symbol;
// symbol = '$';
// Console.WriteLine(symbol);

// char a = '$' ;
// Console.WriteLine(a);

// Создайте переменные, используя различные типы данных, и поместите в них следующие значения:

// 1. Билл

// 2. Гейтс

// 3. Предприниматель

// 4. 28

// 5. 1955

// string name = "Билл";
// string famili = " Гейтс";
// string  professional = " Предприниматель.";
// int a = 28;
// int b = 1955;
// Console.WriteLine(name + famili + professional + " Родился " + a + " октября " + b + " года.");  

// Console.WriteLine("Билл_Гейтс_Предприниматель._Родился_28_октября_1955_года."); 

// string a = "Билл";
// string b = "Гейтс";
// string c = "Предприниматель.";
// string d = "28";
// string e = "1955";
// Console.WriteLine($"{a} {b} {c} Родился {d} октября {e} года");

// Создайте переменную с типом данных byte , поместите в неё число 254. После чего конвертируйте 
// переменную с типом byte в переменную с типом данных long при помощи класса Convert. 
// Выведите результат конвертации.

// byte variable = 254;    
// long number = Convert.ToInt64(variable);
// Console.WriteLine(number);

// Напишите программу, которая задаст пользователю вопрос. Пользователь 
// должен ответить на этот вопрос True или False. Конвертируйте данные,
// которые ввел пользователь в тип данных bool и выведите результат конвертации
// при помощи конкатенации строк.

// Console.WriteLine ("Законодательство США допускало отправку детей по почте до 1913 года");
// Console.WriteLine("Ответь на данный факт true или false");
// Console.WriteLine("Ответ: True");

// Console.WriteLine("Законодательство США допускало отправку детей по почте до 1913 года");
// Console.WriteLine("Ответь на данный факт true или false");
// string answer = Console.ReadLine();
// bool first = Convert.ToBoolean(answer);
// Console.WriteLine("Ответ: " + first);

// Console.WriteLine("Законодательство США допускало отправку детей по почте до 1913 года");
// Console.WriteLine("Ответь на данный факт true или false");
        
// bool poll = Convert.ToBoolean(Console.ReadLine());
// Console.WriteLine("Ответ:" + poll);
        
// Создайте переменную с типом данных string , поместите в неё символ "?". После чего конвертируйте
// переменную с типом string в переменную с символьным типом данных char при помощи метода Parse. 
// Выведите результат конвертации.

// string a = "?";
// char number = char.Parse(a);
// Console.WriteLine(number);

// string sym = "&";
// Console.WriteLine(char.Parse(sym)); 

// Console.WriteLine(char.Parse("?"));

// Ошибки при конвертации

// var a = "1.5";
// double b = Convert.ToDouble(a);
// Console.WriteLine(b);

// string a = "1.5";
// System.Globalization.NumberFormatInfo numberFormatInfo = new System.Globalization.NumberFormatInfo()
// {
//    NumberDecimalSeparator = ".",
// };
// double b = double.Parse(a, numberFormatInfo);
// Console.WriteLine(b);

// Создайте переменную с типом данных string , поместите в неё число 5.25.
// После чего конвертируйте переменную с типом string в переменную с числовым 
// (с плавающей точкой) типом данных при помощи метода Parse. Выведите результат конвертации.

// string a = "5.25";
// System.Globalization.NumberFormatInfo numberFormatInfo = new System.Globalization.NumberFormatInfo()
//     {
//         NumberDecimalSeparator = ".",
//      };
// double b = double.Parse(a, numberFormatInfo);
// Console.WriteLine(b);

// string number = "5.25";
// Console.WriteLine(double.Parse(number));

// string a = "5.25";
// double b = double.Parse(a);
// Console.WriteLine(b);
