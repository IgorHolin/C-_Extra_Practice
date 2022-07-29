// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 


Console.Write("Enter the number of the day of the week: ");
int day = Convert.ToInt32(Console.ReadLine());
while (day < 1 || day > 7)
{
    Console.Write("Enter the number of the day of the week: ");
    day = Convert.ToInt32(Console.ReadLine());
}

bool DayOff(int num)
{
    return (num == 6 || num == 7);
}

Console.Write(DayOff(day));