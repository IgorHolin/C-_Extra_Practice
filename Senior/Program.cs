// 41. QuickSort Realization

Console.Write("Enter the amount of digits in array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] inputArray = new int[size];

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[" + string.Join(", ", array) + "]");
}

FillArray(inputArray);
PrintArray(inputArray);

int[] qsort(int[] array, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex) return array;

    int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

    qsort(array, minIndex, pivotIndex - 1);
    qsort(array, pivotIndex + 1, maxIndex);

    return array;
}

void Swap(ref int left, ref int right)
{
    int temp = left;
    left = right;
    right = temp;
}

int GetPivotIndex(int[] array, int min, int max)
{
    int pivot = min - 1;

    for (int i = min; i <= max; i++)
    {
        if (array[i] < array[max])
        {
            pivot++;
            Swap(ref array[pivot], ref array[i]);
        }
    }
    pivot++;
    Swap(ref array[pivot], ref array[max]);
    return pivot;
}

int[] sortArray = qsort(inputArray, 0, size - 1);
Console.WriteLine();
Console.Write($"Sorted array: [ {string.Join(", ", sortArray)} ]");