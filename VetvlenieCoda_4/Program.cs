// bool rana = true;
// if (rana)
// {
//     Console.WriteLine("Персонаж ранен! Используй аптечку!");
// }

// bool rana = false;
// if (rana)
// {
//     Console.WriteLine("Персонаж ранен! Используй аптечку!");
// }
// else
// {
//     Console.WriteLine("Ранений не обнаружено.");
// }

// int a = 5;
// if (a == 1)
// {
// Console.WriteLine("а равно 1");
// }
// else
// {
// Console.WriteLine("а не равно 1");
// }

// Напишите программу, которая будет является блоком кода из компьютерной игры.
// Пользователь должен передать в программу значение false или true, после чего 
// программа должна сообщить пользователю совершено-ли попадание игроком по вражеской 
// технике ("Попадание!" или "Промах!").


    //    string a = Console.ReadLine();
    //    bool b = Convert.ToBoolean(a);
    //     if (b) 
    //     {
    //      Console.WriteLine("Попадание!"); 
    //     }
    //     else
    //     {
    //      Console.WriteLine("Промах!");
    //      }

    // if (Console.ReadLine() == "True")
    //     {
    //         Console.WriteLine("Попадание!");
    //     }
    //     else
    //     {
    //         Console.WriteLine("Промах.");
    //     }
        

        // bool a = Convert.ToBoolean(Console.ReadLine());

        //     if (a)
        //     { 
        //         Console.WriteLine("Попадание!");
        //     }
           
        //     else
        //     {
        //         Console.WriteLine("Промах!");
        //     }

        // if (bool.Parse(Console.ReadLine()))
        // {
        //     Console.Write("Попадание!");
        // }
        // else
        // {
        //     Console.Write("Промах!");
        // }

        // var a = bool.Parse(Console.ReadLine());
        // if (a) 
        // {
        // Console.WriteLine("Попадание!");
        // }
        // else
        // {
        //     Console.WriteLine("Промах.");
        // }

        // var a = Convert.ToBoolean(Console.ReadLine());
        // if (a == true) Console.WriteLine("Попадание!");
        // else Console.WriteLine("Промах!");

        // System.Console.WriteLine("{0}", bool.Parse(System.Console.ReadLine())?"Попадание!":"Промах.");

        // Напишите программу, которая проверит на четность число вводимое пользователем.
        // Для этого используйте оператор %.

        // Console.WriteLine("Введите число:");
        // int a = int.Parse(Console.ReadLine());                     
        // if (a%2==0) Console.Write("Число чётное");
        // else Console.Write("Число нечётное");
         
        //  Напишите программу, которая будет следить за состоянием системы по следующим параметрам:
        // virus, HighTemperature, NoCooling.

        // Условие:

        // Если в системе обнаружены вирус и высокая температура - это повод бить тревогу: "Угроза повреждения системы!".

        // Если вирус и высокая температура не обнаружены, но программа отследила отсутствие охлаждения - это также является случаем повреждения системы.

        // Если обнаружен вирус, но с температурой и охлаждением все в порядке - необходимо вывести: "Обнаружены незначительные угрозы."

        // Также если обнаружена высокая температура, но не обнаружен вирус и с охлаждением все в порядке - это случай обнаружения незначительных угроз.
         
        //   bool virus = Convert.ToBoolean(Console.ReadLine());
        //   bool HighTemperature = Convert.ToBoolean(Console.ReadLine());
        //   bool NoCooling = Convert.ToBoolean(Console.ReadLine());
        //   if (virus && HighTemperature || NoCooling ) Console.WriteLine("Угроза повреждения системы!");
        //   else Console.WriteLine("Обнаружены незначительные угрозы.");

        string virus = Console.ReadLine();
        string HighTemperature = Console.ReadLine();
        string IsCooling = Console.ReadLine();
        
        if ((virus == "true" && HighTemperature == "true") || IsCooling == "false")
            Console.WriteLine("Угроза повреждения системы!");
        else
            Console.WriteLine("Обнаружены незначительные угрозы.");
        


