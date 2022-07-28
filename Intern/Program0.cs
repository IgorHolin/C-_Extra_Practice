// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Write("Enter the number please: ");
int x = Convert.ToInt32(Console.ReadLine());

int number = new Random().Next(1000,99999);
Console.WriteLine($"Number to check - {number}");

void Devide(int num, int numb)
{
    if (numb%num == 0) Console.Write("Yes");
    else Console.Write("NO");
}

Devide(number, x);