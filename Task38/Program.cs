// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//3 7 22 2 78] -> 76

double[] array = GetArray(6, 0, 15);
Console.WriteLine();
MaxEl(array);
MinEl(array);
double diff = MaxEl(array) - MinEl(array);
Console.WriteLine($"Разность максимального и минимального элементов массива равна {diff}.");


double[] GetArray(int size, int minValue, int maxValue)
{
    double[] numbers = new double[size];
    for (int i = 0; i < size; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        Console.Write($"{numbers[i]} ");
    }
    return numbers;
}

double MaxEl(double[] ar)
{
    double max = ar[0];
    for (int index = 0; index < ar.Length; index++)
    {
        if (ar[index] > max) max = ar[index];
    }
    return max;
}

double MinEl(double[] arr)
{
    double min = arr[0];
    for (int index = 0; index < arr.Length; index++)
    {
        if (arr[index] < min) min = arr[index];
    }
    return min;
}

