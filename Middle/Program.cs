// 28. Подсчитать сумму цифр в числе

Console.Write("Enter the number please: ");
int x = Convert.ToInt32(Console.ReadLine());

int SumOf(int n)
{
    int sum = 0;
    while (n != 0)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}

Console.Write(SumOf(x));