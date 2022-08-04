// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел


Console.Write("Enter the size of array please: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] newa = new int[size];

void FillAndPrintAndCount(int[] arr, int n)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
        Console.Write(arr[i] + "\t");
        if (arr[i] % 2 == 0) count++;
    }
    Console.WriteLine();
    Console.Write($"The number of even numbers in array is: {count}");
}

FillAndPrintAndCount(newa, size);