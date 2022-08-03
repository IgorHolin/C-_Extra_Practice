// 34. Написать программу замену элементов массива на противоположные

int[] arr = new int[10];

void FillPrint(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(-9,10);
        Console.Write(mass[i] + "\t");
    }
}

FillPrint(arr);
Console.WriteLine();

void Change(int[] ar)
{
    for (int i = 0; i < ar.Length; i++)
    {
        ar[i] = -ar[i];
        Console.Write(ar[i] + "\t");
    }
}

Change(arr);