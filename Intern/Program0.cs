// 14. Найти третью цифру числа или сообщить, что её нет

Console.Write("Enter the number please: ");
int x = Convert.ToInt32(Console.ReadLine());

void NumberCheck(int num)
{
    string z = num.ToString();
    if (num < 100 && num > -100) Console.Write("There is no 3-rd digit in this number.");
    else if (num < -100) Console.Write(z[3]);
    else Console.Write(z[2]);
}

NumberCheck(x);