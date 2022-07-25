// 2. Даны два числа. Показать большее и меньшее число

Console.Write("Enter the first number please: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number please: ");
int y = Convert.ToInt32(Console.ReadLine());

void BiggerSmaller(int fNum, int sNum)
{
    if (fNum > sNum) Console.Write($"{fNum} is bigger, {sNum} is smaller.");
    else if (fNum < sNum) Console.Write($"{sNum} is bigger, {fNum} is smaller.");
    else Console.Write("The numbers are even.");
}

BiggerSmaller(x,y);