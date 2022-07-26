//  8. Показать четные числа от 1 до N


Console.Write("Enter the number please: ");
int N = Convert.ToInt32(Console.ReadLine());

void Output(int num)
{
    for (int i = 2; i <= N; i+=2)
    {
        Console.Write(i + " ");
    }
}
Output(N);