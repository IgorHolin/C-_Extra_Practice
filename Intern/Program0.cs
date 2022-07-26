// 6. Выяснить является ли число чётным

Console.Write("Enter the number please: ");
int x = Convert.ToInt32(Console.ReadLine());

void EvenOrOdd(int number)
{
    if (number % 2 == 0) Console.Write($"{number} is even.");
    else Console.WriteLine($"{number} is odd.");
}

EvenOrOdd(x);