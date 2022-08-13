// 41. Выяснить являются ли три числа сторонами треугольника 

Console.WriteLine("Enter the side length: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the side length: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the side length: ");
int c = Convert.ToInt32(Console.ReadLine());

bool Triangle(int fside, int sside, int tside)
{
    return (a + b > c && a + c > b && b + c > a);
}

Console.WriteLine(Triangle(a,b,c));