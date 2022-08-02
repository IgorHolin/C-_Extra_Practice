// 30. Показать кубы чисел, заканчивающихся на четную цифру

Console.Write("Enter the number please: ");
int x = Convert.ToInt32(Console.ReadLine());

void Cube(int n)
{
    if (n % 2 != 0) Console.Write($"{n} is odd!");
    else Console.Write($"Third power of {n} is {n*n*n}");
}

Cube(x);