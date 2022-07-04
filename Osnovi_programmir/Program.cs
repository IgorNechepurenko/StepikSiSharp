// Конвертор валют, рубля к доллару:

// Console.WriteLine("Введите сумму в рублях:");
// var rubles = Convert.ToDouble(Console.ReadLine());
// double dollar = 54.8;
// double euro = 57.4;
// var RubToDollar = Math.Round(rubles/dollar, 2);
// var RubToEuro = Math.Round(rubles/euro, 2);
// Console.WriteLine(rubles + " рублей = " + RubToDollar + " - " + "доллар");
// Console.WriteLine(rubles + " рублей = " + RubToEuro + " - " + "евро");

// Подсчитать площадь трапеции: 

// Console.WriteLine("Введите длинну верхнего основания");
// double a = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите длинну нижнего основания");
// double b = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите высоту");
// double h = Convert.ToDouble(Console.ReadLine());
// var s = (a+b) / 2 * h;
// Console.WriteLine("Площадь трапеции = " + s);

       // Определить какое число больше

// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int max = num1;
// if (num1<num2){
//     max = num2;
//     }
//     else if (num1 == num2) {
//     Console.WriteLine("Числа равны");
//     max = num1;
//     }
// Console.WriteLine("Максимальное число: " + max);

//                 вариант 2

// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int max = 0;
// if (num1>num2) {
//     max = num1;
//    }
//     else if (num1 == num2) {
//     Console.WriteLine("Числа равны");
//     max = num1;
// }
// else {
//     max = num2;
//     }
// Console.WriteLine("Максимальное число: " + max);

// var i = 0;
// while(i<5){
//     Console.WriteLine("Привет Игорёша! ");
//     i++;
//  }

// for(var i = 0; i < 4; i++) {
//     Console.WriteLine("Привет Игорёша! ");
//     }

// Посчитать числа от одного до N

Console.WriteLine("Пожалуйста введите число");
int n = Convert.ToInt32(Console.ReadLine());
for (n = 0; i<=n; i++){
       Console.WriteLine(i)
}
