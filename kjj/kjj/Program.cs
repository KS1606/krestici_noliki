using System;

namespace для_текстов
{

    class Program
    {

        static void Main(string[] args)
        {
            WriteYgad();


        }

        static void WriteYgad()
        {
            
                Random ran = new Random();
                int i = ran.Next(100);
                Console.WriteLine(i);
            Console.WriteLine("введите число");
            int c = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (c == i)
                {
                    Console.WriteLine("ПОБЕДА! ВЫ ОТГАДАЛИ ЧИСЛО.");
                    int gi = 111;
                    gi = i;
                }
                int v = Convert.ToInt32(Console.ReadLine());
                if (v==i)
                {
                    Console.WriteLine("ПОБЕДА! ВЫ ОТГАДАЛИ ЧИСЛО.");
                    int gi = 111;
                    gi = i;
                }
                    

            } while (i<100); 
        }

        
    }
}