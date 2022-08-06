// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.Write("Enter the number of digits in array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[size];

void FillPrint(int[] ar)
{
    for (int i = 0; i < ar.Length; i++)
    {
        ar[i] = new Random().Next(100);
        Console.Write(ar[i] + " ");
    }
}

void PairSum(int[] mas)
{
    int count = mas.Length - 1;
    for (int j = 0; j < mas.Length / 2; j++)
    {
        int res = 0;
        res = mas[j] * mas[count];
        Console.WriteLine($"Sum of {j+1} pair of nums in array = {res}");
        count--;
    }
}

FillPrint(arr);
Console.WriteLine();
PairSum(arr);