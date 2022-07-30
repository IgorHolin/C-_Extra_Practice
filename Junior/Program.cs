// 22. Найти расстояние между точками в пространстве 2D/3D


Console.Write("Enter the dimension you want - 2D or 3D: ");
string d = Console.ReadLine();

if (d.Contains("2") == true)
{
    Console.Write("Enter x1: ");
    double x1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter y1: ");
    double y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter x2: ");
    double x2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter y2: ");
    double y2 = Convert.ToDouble(Console.ReadLine());
    Console.Write(TwoDimension(x1, y1, x2, y2));
}

if (d.Contains("3") == true)
{
    Console.Write("Enter x1: ");
    double x1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter y1: ");
    double y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter z1: ");
    double z1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter x2: ");
    double x2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter y2: ");
    double y2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter z2: ");
    double z2 = Convert.ToDouble(Console.ReadLine());
    Console.Write(ThreeDimensions(x1, y1, z1, x2, y2, z2));
}



double TwoDimension(double a, double b, double c, double d)
{
    return Math.Sqrt(Math.Pow((c - a), 2) + Math.Pow((d - b), 2));
}

double ThreeDimensions(double a, double b, double c, double d, double e, double f)
{
    return Math.Sqrt(Math.Pow((d - a), 2) + Math.Pow((e - b), 2) + Math.Pow((f - c), 2));
}