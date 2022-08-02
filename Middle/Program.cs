// 29. Написать программу вычисления произведения чисел от 1 до N

Console.Write("Enter the number please: ");
int x = Convert.ToInt32(Console.ReadLine());

int Fact(int n)
{
    if (n == 1) return 1;
    else return n * Fact(n-1);
}

Console.Write(Fact(x));