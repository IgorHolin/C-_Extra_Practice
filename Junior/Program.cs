// 21. Программа проверяет пятизначное число на палиндромом. 12321

Console.Write("Enter 5-digit number please: ");
int x = Convert.ToInt32(Console.ReadLine());

while (x < 10000 || x > 99999)
{
    Console.Write("Number should contain 5 digits. Enter once again please: ");
    x = Convert.ToInt32(Console.ReadLine());
}

bool PolyOrNot(int num)
{
    return (num / 10000 == num % 10 && (num / 1000) % 10 == (num / 10) % 10);
}

Console.Write(PolyOrNot(x));
