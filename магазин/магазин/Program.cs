namespace магазин
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BASE();
        }
        static void BASE()
        {
            //Console.Clear();
            Console.WriteLine();
            Console.Write("   Логин:");
            List<char> a = new List<char>();
            string passwor = "";
            for (int i = 0; i < a.Count; i++)
            {
                passwor += a[i];
            }
            Console.WriteLine(passwor);
            Console.Write("   Пароль:");
            List<char> v = new List<char>();
            string password = "";
            for (int i = 0; i < v.Count; i++)
            {
                password += v[i];
                Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine("   Авторизоваться");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow)
            {
                int position = 3;
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
                    int max = position + 1;
                    int min = position - 1;
                    Console.SetCursorPosition(0, max);
                    Console.WriteLine("   ");
                    Console.SetCursorPosition(0, min);
                    Console.WriteLine("   ");
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                    key = Console.ReadKey();
                }
                if (position == 2)
                {
                    Console.SetCursorPosition(11, 2);
                    Console.WriteLine("  ");
                    //List<char> v = new List<char>();
                    Console.SetCursorPosition(11, 2);
                    do
                    {
                        key = Console.ReadKey(true);
                        Console.Write("*");
                        v.Add(key.KeyChar);
                        //ctrl + k + d
                    } while (key.Key != ConsoleKey.Enter);
                    //string password = "";
                    for (int i = 0; i < v.Count; i++)
                    {
                        password += v[i];
                    }
                    ConsoleKeyInfo keys = Console.ReadKey();
                    if (keys.Key == ConsoleKey.UpArrow || keys.Key == ConsoleKey.DownArrow)
                    {
                        if (keys.Key == ConsoleKey.UpArrow)
                        {
                            position--;
                        }
                        if (keys.Key == ConsoleKey.DownArrow)
                        {
                            position++;
                        }
                        int max = position + 1;
                        int min = position - 1;
                        Console.SetCursorPosition(0, max);
                        Console.WriteLine("   ");
                        Console.SetCursorPosition(0, min);
                        Console.WriteLine("   ");
                        Console.SetCursorPosition(0, position);
                        Console.WriteLine("->");
                        keys = Console.ReadKey();
                    }
                    //BASE();
                }
                if (position == 1)
                {
                    Console.SetCursorPosition(11, 1);
                    Console.WriteLine("  ");
                    Console.SetCursorPosition(11, 1);
                    do
                    {
                        key = Console.ReadKey(true);
                        Console.Write(key.Key);
                        a.Add(key.KeyChar);
                        //ctrl + k + d
                    } while (key.Key != ConsoleKey.Enter);
                    for (int i = 0; i < a.Count; i++)
                    {
                        passwor += a[i];
                    }
                    ConsoleKeyInfo keys1 = Console.ReadKey();
                    if (keys1.Key == ConsoleKey.UpArrow || keys1.Key == ConsoleKey.DownArrow)
                    {
                        if (keys1.Key == ConsoleKey.UpArrow)
                        {
                            position--;
                        }
                        if (keys1.Key == ConsoleKey.DownArrow)
                        {
                            position++;
                        }
                        int max = position + 1;
                        int min = position - 1;
                        Console.SetCursorPosition(0, max);
                        Console.WriteLine("   ");
                        Console.SetCursorPosition(0, min);
                        Console.WriteLine("   ");
                        Console.SetCursorPosition(0, position);
                        Console.WriteLine("->");
                        keys1 = Console.ReadKey();
                    }
                    if (position == 2)
                    {
                        Console.SetCursorPosition(11, 2);
                        Console.WriteLine("  ");
                        //List<char> v = new List<char>();
                        Console.SetCursorPosition(11, 2);
                        while (key.Key != ConsoleKey.Enter)
                        {
                            key = Console.ReadKey(true);
                            Console.Write("*");
                            v.Add(key.KeyChar);
                            //ctrl + k + d
                        } 
                        //string password = "";
                        for (int i = 0; i < v.Count; i++)
                        {
                            password += v[i];
                        }
                        ConsoleKeyInfo keys2 = Console.ReadKey();
                        if (keys2.Key == ConsoleKey.UpArrow || keys2.Key == ConsoleKey.DownArrow)
                        {
                            if (keys2.Key == ConsoleKey.UpArrow)
                            {
                                position--;
                            }
                            if (keys2.Key == ConsoleKey.DownArrow)
                            {
                                position++;
                            }
                            int max = position + 1;
                            int min = position - 1;
                            Console.SetCursorPosition(0, max);
                            Console.WriteLine("   ");
                            Console.SetCursorPosition(0, min);
                            Console.WriteLine("   ");
                            Console.SetCursorPosition(0, position);
                            Console.WriteLine("->");
                            keys2 = Console.ReadKey();
                        }
                        //BASE();
                    }
                    //Console.Clear();
                    //BASE();

                }
            }
        }
        static void fff()
        {


        }
          
    }
}