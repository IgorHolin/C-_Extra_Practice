// 17. По двум заданным числам проверять является ли одно квадратом другого


Console.Write("Enter the first number please: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second power please: ");
int y = Convert.ToInt32(Console.ReadLine());

bool PowerOrNot(int a, int b)
{
    return (a == b * b || b == a * a);
}

Console.Write(PowerOrNot(x,y));