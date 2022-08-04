// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] arr = new int[123];
int count = 0;


void FillPrintCount(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(1, 150);
        if (a[i] >= 10 && a[i] < 100) count++;
        Console.Write(a[i] + " ");
    }
}
FillPrintCount(arr);
Console.WriteLine();

Console.Write($"Amount of numbers [10;99] in array is: {count}");