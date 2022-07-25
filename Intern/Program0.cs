// 1. По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Enter the number please: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number in second power please: ");
int numPow = Convert.ToInt32(Console.ReadLine());

void IfPowerMatches(int numb, int numbInPow)
{
    if (numbInPow == numb * numb) Console.Write($"{numbInPow} is {numb} in 2 power");
    else Console.Write($"{numbInPow} isnt {numb} in 2 power");
}

IfPowerMatches(num,numPow);