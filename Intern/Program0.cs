//  9. Показать последнюю цифру трёхзначного числа


Console.Write("Enter the 3-digit number please: ");
int num = Convert.ToInt32(Console.ReadLine());

do
{
    Console.Write("Number should be more or equal 100 and less or equal 999! Enter once again: ");
    int numb = Convert.ToInt32(Console.ReadLine());
    num = numb;
} while (num < 100 || num > 999);

Console.Write($"The last digit in {num} is {num%10}");