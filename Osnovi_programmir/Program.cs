Console.WriteLine("Введите сумму в рублях:");
var rubles = Convert.ToDouble(Console.ReadLine());
double dollar = 54.8;
double euro = 58.4;
var RubToDollar = rubles/dollar;
var RubToEuro = rubles/euro;
Console.WriteLine(rubles + " рублей = " + RubToDollar + " - " + "доллар");
Console.WriteLine(rubles + " рублей = " + RubToEuro + " - " + "евро");
