// 42. Определить сколько чисел больше 0 введено с клавиатуры

Console.Write("Enter the number of digits: ");
int size = Convert.ToInt32(Console.ReadLine());

int PositiveAmount(int amount)
{
    int counter = 0;
    for (int i = 0; i < size; i++)
    {
        Console.Write("Enter the digit please: ");
        int digit = Convert.ToInt32(Console.ReadLine());
        if (digit > 0) counter++;
    }
    return counter;
}
Console.Write($"The amount of positive digits you've entered is {PositiveAmount(size)}");