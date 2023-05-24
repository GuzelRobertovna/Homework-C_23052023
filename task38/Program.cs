// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] array = GetArray(10, -100, 100);
GetDifferenceOfMaxAndMin(array);


double[] GetArray(int size, int minValue, int maxValue)
{
    double[] UserArray = new double[size];
    Random rand = new Random();
    for (int i = 0; i < UserArray.Length; i++)
    {
        UserArray[i] = rand.Next(5) + rand.NextDouble();
        Console.Write($"[{Math.Round(UserArray[i], 3)}] ");
    }
    Console.WriteLine();
    return UserArray;
}

void GetDifferenceOfMaxAndMin(double[] arr)
{
    double maxValue = arr[0];
    double minValue = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > maxValue)
        {
            maxValue = arr[i];
        }
        else if (arr[i] < minValue)
        {
            minValue = arr[i];
        }
    }
    double result = maxValue - minValue;
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна {Math.Round(result, 3)}");
}
