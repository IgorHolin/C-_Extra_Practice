// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int NewNumber()
{
    int n = new Random().Next(10, 100);
    return n;
}

int number = NewNumber();
Console.WriteLine($"Your number is {number}");

void BiggerDigit(int num)
{
    if (num / 10 > num % 10) Console.Write($"Digit {num / 10} is the biggest");
    else Console.Write($"Digit {num % 10} is the biggest");
}
BiggerDigit(number);