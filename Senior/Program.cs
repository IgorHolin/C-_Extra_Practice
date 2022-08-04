// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции


int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];

void FillPrint(int[] a, int s)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(1, 101);
        Console.Write(a[i] + " ");
    }
}

FillPrint(arr, size);
Console.WriteLine();

int sum = 0;
for (int i = 0; i < arr.Length; i += 2)
{
    sum += arr[i];
}

Console.Write($"Sum of numbers with odd index is: {sum}");