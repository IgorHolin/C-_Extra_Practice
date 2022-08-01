// 24. Найти кубы чисел от 1 до N

Console.Write("Enter the number please: ");
double x = Convert.ToDouble(Console.ReadLine());

for (int i = 1; i <= x; i++)
{
    Console.WriteLine($"3rd power of {i} - {Math.Pow(i, 3)}");
}