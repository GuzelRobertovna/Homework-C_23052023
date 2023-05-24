// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] array = GetArray(10, -100, 100);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {GetSum(array)} ");


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

int GetSum(int[] UserArray)
{
    int summa = 0;
    for (int i = 0; i < UserArray.Length; i++)
    {
        if (i % 2 != 0)
        {
            summa += UserArray[i];
        }
    }
    return summa;
}

