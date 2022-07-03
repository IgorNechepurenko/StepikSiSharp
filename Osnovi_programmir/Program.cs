// Конвертор валют, рубля к доллару:

Console.WriteLine("Введите сумму в рублях:");
var rubles = Convert.ToDouble(Console.ReadLine());
double dollar = 54.8;
double euro = 57.4;
var RubToDollar = Math.Round(rubles/dollar, 2);
var RubToEuro = Math.Round(rubles/euro, 2);
Console.WriteLine(rubles + " рублей = " + RubToDollar + " - " + "доллар");
Console.WriteLine(rubles + " рублей = " + RubToEuro + " - " + "евро");

// Подсчитать площадь трапеции: 

// Console.WriteLine("Введите длинну верхнего основания");
// double a = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите длинну нижнего основания");
// double b = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите высоту");
// double h = Convert.ToDouble(Console.ReadLine());
// var s = (a+b) / 2 * h;
// Console.WriteLine("Площадь трапеции = " + s);


