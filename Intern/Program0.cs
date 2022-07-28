// 12. Удалить вторую цифру трёхзначного числа

int n = new Random().Next(100,1000);
Console.WriteLine($"Number is {n}");

void DeleteDigit(int num)
{
    string x = (num/100).ToString();
    string y = (num%10).ToString();
    Console.Write($"The number without second digit is {x}{y}");
}

DeleteDigit(n);