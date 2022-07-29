// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0


Console.Write("Enter x plesae. NB, x != 0: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y plesae. NB, y != 0: ");
int y = Convert.ToInt32(Console.ReadLine());

void WhichQuarter(int a, int b)
{
    if (a > 0 & b > 0) Console.Write("First quarter");
    else if (a < 0 && b > 0) Console.Write("Second quarter");
    else if (a < 0 && b < 0) Console.Write("Third quarter");
    else Console.Write("Fourth quarter");
}

WhichQuarter(x, y);