// 7. Показать числа от -N до N

Console.Write("Enter the number please: ");
int N = Convert.ToInt32(Console.ReadLine());

void Output(int num)
{
    for (int i = -num; i <= num; i++)
    {
        Console.Write(i + " ");
    }
}

Output(N);