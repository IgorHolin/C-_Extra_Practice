// 0. Вывести квадрат числа

Console.Write("Enter the number please: ");
int num = Convert.ToInt32(Console.ReadLine());

int Square(int num)
{
    return num * num;
}

Console.WriteLine($"The square of number you've entered is {Square(num)}");