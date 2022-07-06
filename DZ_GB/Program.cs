//          Определение палиндрома

// Console.WriteLine("Введите пятизначное число");
// int n = Convert.ToInt32(Console.ReadLine());
// int n1, n2, n4, n5;
// n1 = n/10000;
// n2 = (n%10000) /1000;
// n4 = (n%100) /10;
// n5 = n%10;
// if (n1==n5 && n2==n4){
//     Console.WriteLine("Число является палиндромом");
//     }
// else{
//     Console.WriteLine("Число не палиндром");
// }

//Нахождение расстояний между точками

// Console.WriteLine("Введите 6 цифр координат 2-х точек:_");
// double x, y, z, x1, y1, z1, L;
// x = Convert.ToDouble(Console.ReadLine());
// y = Convert.ToDouble(Console.ReadLine());
// z = Convert.ToDouble(Console.ReadLine());
// x1 = Convert.ToDouble(Console.ReadLine());
// y1 = Convert.ToDouble(Console.ReadLine());
// z1 = Convert.ToDouble(Console.ReadLine());
// L = Math.Sqrt((x-x1)*(x-x1)+(y-y1)*(y-y1)+(z-z1)*(z-z1));
// Console.WriteLine("Расстояние между точками =: " +L);

// Найти сумму чисел числа n

// Console.WriteLine("Введите число A: ");
// int sum = 0, n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ваше число =:"+ n);
// for (int i = 1; i <= n; i++)
// {
//     sum = sum +i;
// }
// Console.WriteLine("Сумма чисел А =:" + sum);

              // Найти факториал числа N
// Console.WriteLine("Введите число N: ");
// int sum = 1, n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ваше число ="+ n);
// for (int i = 1; i <= n; i++)
// {
//     sum = sum *i;
// }
// Console.WriteLine("Факториал числа N =" + sum);

       //Определить количество цифр в числе
// Console.WriteLine("Введите число ");
// int n = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// Console.WriteLine("Ваше число = "+ n);
// while ( n>0 )
// {
//     count++;
//     n = n/10;
// }
// Console.WriteLine("Количество цифр в чесле = " + count);

    //  Ввести в массив 8 чисел от 0 до 1

int [] = new int [8];
void FillAray(int[] collection)
{
int lenght = collection.Lengt;
int index = 0;
    while (index<leght)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
    }
void PrintArray(int[]col)
{
    int count = col.Lenght;
    int position = 0;
    while (position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
}
FillAray(array);
PrintArray(array);
   
1.17