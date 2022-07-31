// 23. Показать таблицу квадратов чисел от 1 до N 


Console.Write("Enter the number please: ");
int x = Convert.ToInt32(Console.ReadLine());

void DoublePower(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"Second power of {i} - {i*i}");
    }
}

DoublePower(x);