// 31. Задать массив из 8 элементов и вывести их на экран 

int[] newArr = new int[8];

for (int i = 0; i < newArr.Length; i++)
{
    newArr[i] = new Random().Next(1,10);
    Console.Write(newArr[i] + " ");
}
