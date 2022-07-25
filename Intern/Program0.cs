// 3. По заданному номеру дня недели вывести его название

Console.Write("Enter the number of the day of week: ");
int day = Convert.ToInt32(Console.ReadLine());

// проверка на корректный ввод пользователем дня недели
do  
{
    Console.Write("Enter the number from 1 to 7:");
    int x = Convert.ToInt32(Console.ReadLine());
    day = x;
} while (day > 7);


void WhichDay(int num)
{
    if (num == 1) Console.Write("Monday");
    if (num == 2) Console.Write("Tuesday");
    if (num == 3) Console.Write("Wednesday");
    if (num == 4) Console.Write("Thursday");
    if (num == 5) Console.Write("Friday");
    if (num == 6) Console.Write("Staurday");
    if (num == 7) Console.Write("Sunday");
}

WhichDay(day);