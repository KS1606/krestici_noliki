/*
Console.SetCursorPosition(50, 10);
Console.WriteLine("hello!");
*/

int position = 1;
ConsoleKeyInfo key = Console.ReadKey();
while (key.Key != ConsoleKey.Enter)
{
    if (key.Key == ConsoleKey.UpArrow)
    {
        position--;
    }
    if (key.Key == ConsoleKey.DownArrow)
    {
        position++;
    }
    Console.Clear();
    Console.WriteLine(" ВВЕДИТЕ ВАШ ЛЮБИМЫЙ ЦВЕТ ");
    Console.WriteLine("1.КРАСНЫЙ");
    Console.WriteLine("2.ЧЕРНЫЙ");
    Console.WriteLine("3.ЖЕЛТЫЙ");
    Console.WriteLine("4.ЗЕЛЕНЫЙ");
    Console.SetCursorPosition(0, position);
    Console.WriteLine("->");

    key = Console.ReadKey();
}
if (position == 2 )
{
    Console.Clear();
    Console.WriteLine("это черный");
}
/*
//Console.Clear();

d = DateTime.Now;
d = d.AddDays(-1);
*/
/*
DateTime d = new DateTime(2022, 07, 15);
d = d.AddDays(-1);
DateTime a = new DateTime(2022, 07, 15);
DateTime n = new DateTime(2022, 07, 25);
DateTime f = new DateTime(2022, 07, 12);
Console.WriteLine(" Выбрана дата 14.07.2022 0:00:00");
Console.WriteLine(" -----------------------");

string[] zametka = new string[] { "Встреча с друзьями", "Приехать на пары", "Сходить в магазин", "Сходить в гости", "ПОЕЗДКА В ТВЕРЬ" };
while (true)
{
    int s = 0;
    int i = 1;
    s = i + s;
    ConsoleKeyInfo z = Console.ReadKey();

    if (z.Key == ConsoleKey.RightArrow)
    {
        Console.Clear();
        d = d.AddDays(+s);
        Console.Write(" Выбрана дата ");
        Console.WriteLine(d);
        Console.WriteLine(" -------------------------------");


        if (d == a & z.Key == ConsoleKey.UpArrow || z.Key == ConsoleKey.DownArrow)
        {
            int position = 1;
            ConsoleKeyInfo ke = Console.ReadKey();
            while (ke.Key != ConsoleKey.Enter)
            {
                if (ke.Key == ConsoleKey.UpArrow)
                {
                    position--;
                }
                if (ke.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                Console.Clear();
                Console.WriteLine(" Выбрана дата 15.07.2022 0:00:00");
                Console.WriteLine(" -------------------------------");

                Console.Write("  1.");
                Console.WriteLine(zametka[0]);
                Console.Write("  2.");
                Console.WriteLine(zametka[2]);
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                ke = Console.ReadKey();
            }
            if (position == 3)
            {
                Console.Clear();
                Console.WriteLine("это черный");
            }
            ke = Console.ReadKey();
            if (ke.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                Console.Write(" Выбрана дата ");
                Console.WriteLine(d);
                Console.WriteLine(" -------------------------------");
            }

        }


        ConsoleKeyInfo key = Console.ReadKey();
        if (d == n & key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow)
        {
            int position = 1;
            while (key.Key != ConsoleKey.Enter)
            {
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                Console.Clear();
                Console.WriteLine(" Выбрана дата 15.07.2022 0:00:00");
                Console.WriteLine(" -------------------------------");

                Console.Write("  1.");
                Console.WriteLine(zametka[1]);
                Console.Write("  2.");
                Console.WriteLine(zametka[3]);
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                key = Console.ReadKey();
            }
            if (position == 3)
            {
                Console.Clear();
                Console.WriteLine("это черный");
            }
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                Console.Write(" Выбрана дата ");
                Console.WriteLine(d);
                Console.WriteLine(" -------------------------------");
            }

        }

    }


    if (z.Key == ConsoleKey.LeftArrow)
    {
        Console.Clear();
        d = d.AddDays(-s);
        Console.Write(" Выбрана дата ");
        Console.WriteLine(d);
        Console.WriteLine(" -------------------------------");

        if (d == a)
        {
            
        }

    }
    if (z.Key == ConsoleKey.Escape)
    {
        break;
    }
}





  static void CEB()
        {
            DateTime d = new DateTime(2022, 07, 15);
            d = DateTime.Now;
            d = d.AddDays(-1);
            
            ConsoleKeyInfo o = Console.ReadKey();
            while (o.Key != ConsoleKey.Escape)
            {

                o = Console.ReadKey();
                if (o.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    Console.WriteLine("Выбрана дата 14.07.2022");
                    Console.WriteLine("-----------------------");
                    ConsoleKeyInfo ke = Console.ReadKey();
                    if (ke.Key == ConsoleKey.RightArrow)
                    {
                        Console.Clear();
                        Console.WriteLine(d.AddDays(+1));
                        string[] zametka = Zamet();
                        Console.WriteLine(zametka[0]);
                        F();
                        ke = Console.ReadKey();
                    }
                    if (ke.Key == ConsoleKey.LeftArrow)
                    {
                        Console.Clear();
                        Console.WriteLine("Выбрана дата 13.07.2022");
                        Console.WriteLine("-----------------------");
                        string[] zamet = Zamet();
                        Console.WriteLine(zamet[2]);
                        ConsoleKeyInfo k = Console.ReadKey();
                        if (k.Key == ConsoleKey.RightArrow)
                        {
                            Console.Clear();
                            Console.WriteLine("Выбрана дата 14.07.2022");
                            Console.WriteLine("-----------------------");
                            ConsoleKeyInfo e = Console.ReadKey();
                            if (e.Key == ConsoleKey.RightArrow)
                            {
                                Console.Clear();
                                Console.WriteLine("Выбрана дата 15.07.2022");
                                Console.WriteLine("-----------------------");
                                string[] zametka = Zamet();
                                Console.WriteLine(zametka[0]);
                                F();
                                e = Console.ReadKey();
                            }
                        }
                        if (k.Key == ConsoleKey.LeftArrow)
                        {
                            Console.Clear();
                            Console.WriteLine("Выбрана дата 12.07.2022");
                            Console.WriteLine("-----------------------");
                            ConsoleKeyInfo q = Console.ReadKey();
                            if (q.Key == ConsoleKey.RightArrow)
                            {
                                Console.Clear();
                                Console.WriteLine("Выбрана дата 13.07.2022");
                                Console.WriteLine("-----------------------");
                                Console.WriteLine(zamet[2]);
                                ConsoleKeyInfo w = Console.ReadKey();
                                if (w.Key == ConsoleKey.RightArrow)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Выбрана дата 14.07.2022");
                                    Console.WriteLine("-----------------------");
                                    ConsoleKeyInfo r = Console.ReadKey();
                                    if (r.Key == ConsoleKey.RightArrow)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Выбрана дата 15.07.2022");
                                        Console.WriteLine("-----------------------");
                                        string[] zametka = Zamet();
                                        Console.WriteLine(zametka[0]);
                                        F();
                                        r = Console.ReadKey();
                                    }
                                }
                                if (w.Key == ConsoleKey.LeftArrow)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Выбрана дата 12.07.2022");
                                    Console.WriteLine("-----------------------");
                                    ConsoleKeyInfo g = Console.ReadKey();
                                    if (g.Key == ConsoleKey.RightArrow)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Выбрана дата 13.07.2022");
                                        Console.WriteLine("-----------------------");
                                        Console.WriteLine(zamet[2]);
                                        ConsoleKeyInfo a = Console.ReadKey();
                                        if (a.Key == ConsoleKey.RightArrow)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Выбрана дата 14.07.2022");
                                            Console.WriteLine("-----------------------");
                                            ConsoleKeyInfo j = Console.ReadKey();
                                            if (j.Key == ConsoleKey.RightArrow)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Выбрана дата 15.07.2022");
                                                Console.WriteLine("-----------------------");
                                                string[] zametka = Zamet();
                                                Console.WriteLine(zametka[0]);
                                                F();
                                                j = Console.ReadKey();
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
                if (o.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    Console.WriteLine("Выбрана дата 16.07.2022");
                    Console.WriteLine("-----------------------");
                    ConsoleKeyInfo v = Console.ReadKey();
                    if (v.Key == ConsoleKey.LeftArrow)
                    {
                        Console.Clear();
                        Console.WriteLine("Выбрана дата 15.07.2022");
                        Console.WriteLine("-----------------------");
                        string[] zametka = Zamet();
                        Console.WriteLine(zametka[0]);
                        F();
                        v = Console.ReadKey();
                    }
                    if (v.Key == ConsoleKey.RightArrow)
                    {
                        Console.Clear();
                        Console.WriteLine("Выбрана дата 17.07.2022");
                        Console.WriteLine("-----------------------");
                        string[] zametk = Zamet();
                        Console.WriteLine(zametk[1]);
                        ConsoleKeyInfo i = Console.ReadKey();
                        if (i.Key == ConsoleKey.LeftArrow)
                        {
                            Console.Clear();
                            Console.WriteLine("Выбрана дата 16.07.2022");
                            Console.WriteLine("-----------------------");
                            ConsoleKeyInfo p = Console.ReadKey();
                            if (p.Key == ConsoleKey.LeftArrow)
                            {
                                Console.Clear();
                                Console.WriteLine("Выбрана дата 15.07.2022");
                                Console.WriteLine("-----------------------");
                                string[] zametka = Zamet();
                                Console.WriteLine(zametka[0]);
                                F();
                                p = Console.ReadKey();
                            }
                            if (p.Key == ConsoleKey.RightArrow)
                            {
                                Console.Clear();
                                Console.WriteLine("Выбрана дата 17.07.2022");
                                Console.WriteLine("-----------------------");
                                Console.WriteLine(zametk[1]);
                                ConsoleKeyInfo h = Console.ReadKey();
                                if (h.Key == ConsoleKey.LeftArrow)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Выбрана дата 16.07.2022");
                                    Console.WriteLine("-----------------------");
                                    ConsoleKeyInfo u = Console.ReadKey();
                                    if (u.Key == ConsoleKey.LeftArrow)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Выбрана дата 15.07.2022");
                                        Console.WriteLine("-----------------------");
                                        string[] zametka = Zamet();
                                        Console.WriteLine(zametka[0]);
                                        F();
                                        u = Console.ReadKey();
                                    }
                                }
                            }

                        }
                    }

                }

            }
        }*/



