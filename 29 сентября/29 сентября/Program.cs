
int[] massive = new int[] { -1, 5, 8, -2, 0 };

int[] onlyPositive = massive.Where(item=>item>=0).ToArray();

int[] firs = massive.First(item=>item>=0).;

foreach (int item in massive)
{
    if (item>=0)
    {
        Console.WriteLine(item);
    }
}