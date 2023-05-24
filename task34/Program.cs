// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] array = GetArray(10, 100, 1000);
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве равна {GetCountOfPositiveElements(array)}");


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"[{arr[i]}] ");
    }
    return arr;
}

int GetCountOfPositiveElements(int[] UserArray)
{
    int PositiveCount = 0;
    for (int i = 0; i < UserArray.Length; i++)
    {
        if (UserArray[i] % 2 == 0)
        {
            PositiveCount++;
        }
    }
    return PositiveCount;
}