// 43. Написать программу преобразования десятичного числа в двоичное

Console.Write("Enter the number please: ");
int num = Convert.ToInt32(Console.ReadLine());

string GetNum(int number)
{
    string res = string.Empty;
    while (number != 0)
    {
        string nextdigit = (number%2).ToString();
        res = nextdigit + res ;
        number /= 2;
    }
    return res;
}

Console.Write(GetNum(num));