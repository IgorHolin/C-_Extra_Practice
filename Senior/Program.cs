// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int[] newa = new int[12];

void Fill(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(9);
    }
}
Fill(newa);

void Print(int[] ar)
{
    foreach (var item in ar)
    {
        Console.Write(item + " ");
    }
}

Print(newa);

int resulT(int[] mas)
{
    int result = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        result += mas[i];
    }
    return result;
}

Console.Write($"Result: {resulT(newa)}");