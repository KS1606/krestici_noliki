using System;

namespace ОАИП
{
    class Program

    {
        static int KS()
        {
            Random rnd = new Random();
            int v = rnd.Next(100);
            return v;
        }
         static void Main(string[] args)
         {
            int a = 0;
            int b = KS();
            Console.Write("Угадайте число от 1 до 100");
            for (int i = 1; i < 100000; i++) 
            {
                Console.Write($" Попытка {i}: ");
                int c = Convert.ToInt32(Console.ReadLine());
                a = c;
                if ( a <= 100)
                {
                    if (a == b)
                    {
                        Console.WriteLine("Поздравляю вы угадали число! ");
                        break;
                    }
                    
                    if (a < b)
                    {
                        Console.WriteLine("Нужно больше");
                    }
                    
                    if (a > b)
                    {
                        Console.WriteLine("Нужно меньше");
                    }
                }
                else
                {
                    Console.WriteLine("Нужно ввести число от 1 до 100");
                }

            }
         }
    }
}


