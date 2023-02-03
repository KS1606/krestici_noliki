
Console.WriteLine("напишите да если хотите начать программу");
string? kgc = Console.ReadLine();
while (kgc == "да" || kgc=="ДА" || kgc=="Да")
{
    Console.WriteLine("ВЫБИРИТЕ ОПЕРАЦИЮ КОТОРУЮ ХОТИТЕ ВЫПОЛНИТЬ");
    Console.WriteLine("1. Сложить два числа");
    Console.WriteLine("2. Вычесть первое из второго");
    Console.WriteLine("3. Перемножить два числа");
    Console.WriteLine("4. Разделить первое на второе");
    Console.WriteLine("5. Возвести в степень N первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1 процент от числа");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9. Выйти из программы");

    int deictvie = Convert.ToInt32(Console.ReadLine()); 

        if (deictvie == 1)
        {
            Console.WriteLine("введите первое число");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("результат" + (z + b));
        }
        else if (deictvie == 2)
        {
            Console.WriteLine("введите первое число");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе число");
            int b2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("результат" + (a2 - b2));
            

        }
        else if (deictvie == 3)
        {
            Console.WriteLine("введите первое число");
            int a3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе число");
            int b3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("результат" + (a3 * b3));
            

        }
        else if (deictvie == 4)
         {
        Console.WriteLine("введите первое число");
        int a4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите второе число");
        int b4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("результат" + (a4 / b4));


         }
        else if (deictvie == 4)
        {
        Console.WriteLine("введите первое число");
        int a4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите второе число");
        int b4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("результат" + (a4 / b4));


        }
        else if (deictvie == 5)
        {
        
        Console.WriteLine("введите первое число");
        int a5 = Convert.ToInt32(Console.ReadLine());
        int a6 = a5;
        Console.WriteLine("введите второе число");

        for (int b5 = Convert.ToInt32(Console.ReadLine()); b5 > 0; b5--)
        a6=a6*a5;
        }

}


