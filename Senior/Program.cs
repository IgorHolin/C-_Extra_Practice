// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

int[] newA = new int[8];

for (int i = 0; i < newA.Length; i++)
{
    newA[i] = new Random().Next(2);
    Console.Write(newA[i] + " ");
}
