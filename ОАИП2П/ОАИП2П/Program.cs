int y = Convert.ToInt32(Console.ReadLine());
    if (y < 0)
{ 
}
class ggg
{
    static void Main(string[] args)
    {
        int[,] a = new int[10, 10];

        for(int m = 1; m < 10;m++)
        {
            for (int n = 1; n < 10;n++)
            {   
                Console.Write(a[m, n] + m * n + "\t" );
            }

            Console.WriteLine();
        }
    }
}

