// 35. Определить, присутствует ли в заданном массиве, некоторое число 

Console.Write("Enter the size of array please: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the the number to find: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];

for (int i = 0; i < size; i++)
{
    arr[i] = new Random().Next(0, 21);
    Console.Write(arr[i] + "\t");
}
Console.WriteLine();

if (arr.Contains(num) == true) Console.Write($"{num} is in array.");
else Console.Write($"Array doesnt contain {num}");