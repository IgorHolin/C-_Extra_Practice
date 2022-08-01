// 27. Определить количество цифр в числе

//string

Console.Write("Enter the number please: ");
int x = Convert.ToInt32(Console.ReadLine());

void HowMuch(int num)
{
    int result;
    string y = num.ToString();
    if (y.Contains("-") == true)
    {
        result = y.Length - 1;
    }
    else result = y.Length;
    Console.Write($"Amount of digits in {num} is {result}");
}
HowMuch(x);

//int

Console.Write("Enter the number please: ");
int x = Convert.ToInt32(Console.ReadLine());

int HowMuch(int y)
{
    int result = 0;
    for (int i = 0; y != 0; i++)
    {
        y = y / 10;
        result++;
    }
    return result;
}
Console.Write($"Amoutn of digits in {x} - {HowMuch(x)}");