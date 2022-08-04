// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] newarr = new int[123];

int count = 0;
for (int i = 0; i < newarr.Length; i++)
{
    newarr[i] = new Random().Next(150);
    if (newarr[i] >= 10 && newarr[i] < 100) count++;
    Console.Write(newarr[i] + " ");
}
Console.WriteLine();
Console.Write($"Amount of numbers [10;99] is {count}");


