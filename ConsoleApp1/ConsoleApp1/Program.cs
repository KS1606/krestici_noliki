
/*
class ForDemo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ведите число");
        int r = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i * i <= r; i++)
        {
            if (r % i == 0)
                Console.Write(" "+ i +" ");
        }
        Console.Write(" "+ r +" ");
    }
}*/

Console.WriteLine("Ведите число у которого хотите узнать делители");
int y = Convert.ToInt32(Console.ReadLine());




for (int u = 1; u * u <= y; i++)
{
    if (y % u == 0)
        Console.Write(" " + u + " ");
}
Console.Write(" " + y + " ");
