// 25. Найти сумму чисел от 1 до А

Console.Write("Enter the number please: ");
int x = Convert.ToInt32(Console.ReadLine());

int SumOf(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += i;
    }
    return sum;
}
Console.Write(SumOf(x));