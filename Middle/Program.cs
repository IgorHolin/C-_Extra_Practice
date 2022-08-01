// 26. Возведите число А в натуральную степень B используя цикл

Console.Write("Enter the number please: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the power please: ");
int y = Convert.ToInt32(Console.ReadLine());

int Multi(int number, int power)
{
    int result = 1;
    for (int i = 1; i <= power; i++)
    {
        result *= number;
    }
    return result;
}

Console.Write(Multi(x,y));