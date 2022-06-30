// int n, x;
// n = Convert.ToInt32(Console.ReadLine());
// x = (n % 100) / 10;
// Console.WriteLine(x);

// int n;
// n = Convert.ToInt32(Console.ReadLine());
// if (n % 100 == n)
//     Console.WriteLine("Число меньше 100");
// else{
//     Console.WriteLine(Convert.ToString(n)[2]);
// }


// int n;
// n = Convert.ToInt32(Console.ReadLine());
// if (n % 6 == 0 || n % 7 == 0)
//     Console.WriteLine("Сейчас выходной день!");
// else
//     Console.WriteLine("Работай");

//     int x, y;
// x = Convert.ToInt32(Console.ReadLine());
// y = Convert.ToInt32(Console.ReadLine());
// if (x > 0 && y > 0)
//     Console.WriteLine("I");
// if (x < 0 && y > 0)
//     Console.WriteLine("II");
// if (x < 0 && y < 0)
//     Console.WriteLine("III");
// if (x > 0 && y < 0)
//     Console.WriteLine("IV");

// int x, y;
// x = Convert.ToInt32(Console.ReadLine());
// y = Convert.ToInt32(Console.ReadLine());
// if (x > 0 && y > 0){
//     Console.WriteLine("x = (0, +~)");
//     Console.WriteLine("y = (0, +~)");
// }
// if (x < 0 && y > 0){
//     Console.WriteLine("x = (-~, 0)");
//     Console.WriteLine("y = (0, +~)");
// }
// if (x < 0 && y < 0){
//     Console.WriteLine("x = (-~, 0)");
//     Console.WriteLine("y = (-~, 0)");
// }
// if (x > 0 && y < 0){
//     Console.WriteLine("x = (0, +~)");
//     Console.WriteLine("y = (-~, 0)");
// }

// int n;
// n = Convert.ToInt32(Console.ReadLine());
// if (n > 0 && n < 5){
//     if (n == 1){
//         Console.WriteLine("x = (0, +~)");
//         Console.WriteLine("y = (0, +~)");
//     }
//     if (n == 2){
//         Console.WriteLine("x = (-~, 0)");
//         Console.WriteLine("y = (0, +~)");
//     }
//     if (n == 3){
//         Console.WriteLine("x = (-~, 0)");
//         Console.WriteLine("y = (-~, 0)");
//     }
//     if (n == 4){
//         Console.WriteLine("x = (0, +~)");
//         Console.WriteLine("y = (-~, 0)");
//     }
// }
// else{
//     Console.WriteLine("Такой четверти не существует! Ты Врун!");
// }

// double x, y, x1, y1, len;
// x = Convert.ToDouble(Console.ReadLine());
// y = Convert.ToDouble(Console.ReadLine());
// x1 = Convert.ToDouble(Console.ReadLine());
// y1 = Convert.ToDouble(Console.ReadLine());
// len = Math.Sqrt((x - x1) * (x - x1) + (y - y1) * (y - y1));
// Console.WriteLine(len);

// int n, i = 1;
// n = Convert.ToInt32(Console.ReadLine());
// while (i <= n)
// {
//     Console.WriteLine(i * i);
//     i++;
// }

// int n;
// n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= n; i++){
//     Console.WriteLine(i * i);
// }


 Random run = new Random();
 double x = run.Next(0, 30);
 double c = run.Next(0, 30);
 Console.WriteLine(x);
 Console.WriteLine(c);
 Console.WriteLine($"сумма двух случайных чисел: {x+c}");
