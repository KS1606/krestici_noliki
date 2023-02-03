namespace Ежедневник
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            BASE();
        }
        static string[] Zamet()
        {
            string[] zametka = new string[] { "Встреча с друзьями", "Приехать на пары", "Сходить в магазин", "Сходить в гости", "ПОЕЗДКА В ТВЕРЬ" };
            return zametka;
        }
        static void NEW()
        {
            note zam = new note();
            zam.Note = " Описание : 1. В 10:15 электричка 2.В 12:00 концерт на площади";
            List<note> zametochka = new List<note>();
            zametochka.Add(zam);
            foreach (note note in zametochka)
            {
                Console.WriteLine(zam.Note);
            }
        }
        static void NEW1()
        {
            note zam = new note();
            zam.Note = " Описание : Приехать к 14:30 на площадь возле фонтана. Встреча с Ксюшей и  Аней";
            List<note> zametochka = new List<note>();
            zametochka.Add(zam);
            foreach (note note in zametochka)
            {
                Console.WriteLine(zam.Note);
            }
        }
        static void NEW2()
        {
            note zam = new note();
            zam.Note = " Описание : Купить хлеб, молоко, картошку, салат и что нибудь к чаю";
            List<note> zametochka = new List<note>();
            zametochka.Add(zam);
            foreach (note note in zametochka)
            {
                Console.WriteLine(zam.Note);
            }
        }
        static void NEW3()
        {
            note zam = new note();
            zam.Note = " Описание : Купить что нибудь к чаю. Адресс : ул. Школьная, дом 10, кв.56";
            List<note> zametochka = new List<note>();
            zametochka.Add(zam);
            foreach (note note in zametochka)
            {
                Console.WriteLine(zam.Note);
            }
        }
        static void NEW4()
        {
            note zam = new note();
            zam.Note = " Описание : Пары Архитектуры аппаратных средств и БЖД ";
            List<note> zametochka = new List<note>();
            zametochka.Add(zam);
            foreach (note note in zametochka)
            {
                Console.WriteLine(zam.Note);
            }
        }
        static void BASE()
        {
            DateTime d = new DateTime(2022, 07, 15);
            d = d.AddDays(-1);
            DateTime a = new DateTime(2022, 07, 15);
            DateTime n = new DateTime(2022, 07, 25);
            DateTime f = new DateTime(2022, 07, 12);
            Console.WriteLine(" Выбрана дата 14.07.2022 0:00:00");
            Console.WriteLine(" -------------------------------");


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


                    if (d == a) 
                    {
                        Console.Clear();
                        Console.WriteLine(" Выбрана дата 15.07.2022 0:00:00");
                        Console.WriteLine(" -------------------------------");
                        CHIFRA1();
                        SAS();
                    }

                    if (d == n) 
                    {
                        Console.Clear();
                        Console.WriteLine(" Выбрана дата 25.07.2022 0:00:00");
                        Console.WriteLine(" -------------------------------");
                        CHIFRA2();
                        NAS();
                    }

                    if (d == f)
                    {
                        Console.Clear();
                        Console.WriteLine(" Выбрана дата 12.07.2022 0:00:00");
                        Console.WriteLine(" -------------------------------");
                        CHIFRA3();
                        VAS();
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
                        Console.Clear();
                        Console.WriteLine(" Выбрана дата 15.07.2022 0:00:00");
                        Console.WriteLine(" -------------------------------");
                        CHIFRA1();
                        SAS();
                    }

                    if (d == n)
                    {
                        Console.Clear();
                        Console.WriteLine(" Выбрана дата 25.07.2022 0:00:00");
                        Console.WriteLine(" -------------------------------");
                        CHIFRA2();
                        NAS();
                    }

                    if (d == f)
                    {
                        Console.Clear();
                        Console.WriteLine(" Выбрана дата 12.07.2022 0:00:00");
                        Console.WriteLine(" -------------------------------");
                        CHIFRA3();
                        VAS();
                    }
                }
                if (z.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
        static void SAS()
        {
            DateTime a = new DateTime(2022, 07, 15);
            ConsoleKeyInfo ke = Console.ReadKey();
            if (ke.Key == ConsoleKey.UpArrow || ke.Key == ConsoleKey.DownArrow)
            {
                int position = 1;

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
                    CHIFRA1();
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");

                    ke = Console.ReadKey();
                }
                if (position == 2)
                {
                    Console.Clear();
                    string[] zametka = Zamet();
                    Console.WriteLine(zametka[0]);
                    Console.WriteLine(" -------------------------------");
                    NEW1();
                    Console.Write(" Дата и время : ");
                    Console.WriteLine(a);
                }
                if (position == 3)
                {
                    Console.Clear();
                    string[] zametka = Zamet();
                    Console.WriteLine(zametka[2]);
                    Console.WriteLine(" -------------------------------");
                    NEW2();
                    Console.Write(" Дата и время : ");
                    Console.WriteLine(a);
                }
                ke = Console.ReadKey();
                if (ke.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.Write("1 Выбрана дата ");
                    Console.WriteLine(a);
                    Console.WriteLine(" -------------------------------");
                    CHIFRA1();
                    SAS();
                }
            }
        }
        static void NAS()
        {
            DateTime n = new DateTime(2022, 07, 25);
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow)
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
                    Console.WriteLine(" Выбрана дата " + n );
                    Console.WriteLine(" -------------------------------");
                    CHIFRA2();
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");

                    key = Console.ReadKey();
                }
                if (position == 2)
                {
                    Console.Clear();
                    string[] zametka = Zamet();
                    Console.WriteLine(zametka[2]);
                    Console.WriteLine(" -------------------------------");
                    NEW4();
                    Console.Write(" Дата и время : ");
                    Console.WriteLine(n);
                }
                if (position == 3)
                {
                    Console.Clear();
                    string[] zametka = Zamet();
                    Console.WriteLine(zametka[2]);
                    Console.WriteLine(" -------------------------------");
                    NEW3();
                    Console.Write(" Дата и время : ");
                    Console.WriteLine(n);
                }
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.Write("1 Выбрана дата ");
                    Console.WriteLine(n);
                    Console.WriteLine(" -------------------------------");
                    CHIFRA2();
                    NAS();
                }
            }
        }
        static void VAS()
        {
            DateTime F = new DateTime(2022, 07, 12);
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow)
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
                    Console.WriteLine(" Выбрана дата 12.07.2022 0:00:00");
                    Console.WriteLine(" -------------------------------");
                    CHIFRA3();
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");

                    key = Console.ReadKey();
                }
                if (position == 2)
                {
                    Console.Clear();
                    string[] zametka = Zamet();
                    Console.WriteLine( zametka[4]);
                    Console.WriteLine(" -------------------------------");
                    NEW();
                    Console.Write(" Дата и время : ");
                    Console.WriteLine(F);

                }
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.Write("1 Выбрана дата ");
                    Console.WriteLine(F);
                    Console.WriteLine(" -------------------------------");
                    CHIFRA3();
                    VAS();
                }
            }
        }
        static void CHIFRA1()
        {
            string[] zametka = Zamet();
            Console.Write("  1.");
            Console.WriteLine(zametka[0]);
            Console.Write("  2.");
            Console.WriteLine(zametka[2]);
        }
        static void CHIFRA2()
        {
            string[] zametka = Zamet();
            Console.Write("  1.");
            Console.WriteLine(zametka[1]);
            Console.Write("  2.");
            Console.WriteLine(zametka[3]);
        }
        static void CHIFRA3()
        {
            string[] zametka = Zamet();
            Console.Write("  1.");
            Console.WriteLine(zametka[4]);
        }
    }
}
