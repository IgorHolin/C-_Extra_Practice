// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

Console.Write("Enter the number of digits in array: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] arr = new double[size];

for (int i = 0; i < size; i++)
{
    arr[i] = new Random().NextDouble() * 100;
    arr[i] = Math.Round(arr[i], 2);
}

for (int i = 0; i < size - 1; i++)
{
    for (int j = i + 1; j > 0; j--)
    {
        if (arr[j] > arr[i])
        {
            double temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
Console.WriteLine("Array : " + "[" + string.Join("; ", arr) + "]");
Console.Write($"Differ btween maximal and minimal digits of array is: {arr[0] - arr[size - 1]}");
