Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine());
if (x > 0)
{
    for (int i = 1; i < x + 1; i++)
    {
        if (i == x) 
        {
        Console.WriteLine(Math.Pow(i, 3));
        break;
        }
        Console.Write(Math.Pow(i, 3) + ",");
    }
}
else if (x < 0)
{
    for (int i = -1; i > x - 1; i--)
    {
        if (i == x)
        {
            Console.WriteLine(Math.Pow(i, 3));
            break;
        }
        Console.Write(Math.Pow(i, 3) + ",");
    }
}
else Console.WriteLine("Error");