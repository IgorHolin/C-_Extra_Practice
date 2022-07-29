// 15. Дано число. Проверить кратно ли оно 7 и 23

Console.Write("Enter the number please: ");
int x = Convert.ToInt32(Console.ReadLine());

bool Divide(int num)
{
    return (num % 7 == 0 && num % 23 == 0);
}

Console.Write(Divide(x));