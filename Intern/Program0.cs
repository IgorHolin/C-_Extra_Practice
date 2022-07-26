// 4. Найти максимальное из трех чисел

Console.Write("Enter the number please: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number please: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number please: ");
int z = Convert.ToInt32(Console.ReadLine());

int TheBiggestNumber(int first, int second, int third)
{
    int maxOfTwo = Math.Max(first,second);
    int anotherMax = Math.Max(maxOfTwo,third);
    return anotherMax;
}
Console.Write(TheBiggestNumber(x,y,z));