// 20. Задать номер четверти, показать диапазоны для возможных координат

Console.Write("Enter the number of quarter please: ");
int q = Convert.ToInt32(Console.ReadLine());

while (q > 4 || q < 1)
{
    Console.Write("Enter number from 1 to 4: ");
    q = Convert.ToInt32(Console.ReadLine());
}

if (q == 1) Console.Write("Range of x from 0 to +infinity, range of y from 0 to +infinity");
if (q == 2) Console.Write("Range of x from 0 to -infinity, range of y from 0 to +infinity");
if (q == 3) Console.Write("Range of x from 0 to -infinity, range of y from 0 to -infinity");
if (q == 4) Console.Write("Range of x from 0 to +infinity, range of y from 0 to -infinity");
