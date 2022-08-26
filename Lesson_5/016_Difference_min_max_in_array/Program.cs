Console.Clear();
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = new double[6];

Random random = new Random();

// Заполняем массив разномными значениями от 1 до 99
double[] FillAndPrintArray(double[] arr)
{
    double[] newArr = arr;
    Console.WriteLine("Сгенерирован массив: ");
    for (int i = 0; i < newArr.Length; i++)
    {
        newArr[i] = random.Next(1, 100);
        Console.Write(newArr[i] + " ");
    }
    Console.WriteLine();
    return newArr;
}

double[] newArray = FillAndPrintArray(array);

// Находим минимальное число в массиве
double GetMinInArrayAndPrint(double[] arr)
{
    double minNum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (minNum > arr[i])
        {
            minNum = arr[i];
        }
    }
    Console.WriteLine($"Минимальное число в массиве: {minNum}");
    return minNum;
}

// Находим максимальное число в массиве
double GetMaxInArrayAndPrint(double[] arr)
{
    double maxNum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (maxNum < arr[i])
        {
            maxNum = arr[i];
        }
    }
    Console.WriteLine($"Максимальное число в массиве: {maxNum}");
    return maxNum;
}

double maxNumber = GetMaxInArrayAndPrint(newArray);
double minNumber = GetMinInArrayAndPrint(newArray);

// Выводим разницу между минимальным и максимальным
void DiffMinAndMaxInArray(double max, double min)
{
    double diff = max - min;
    Console.WriteLine($"\nРазница между максимальным {max} и минимальным {min}: {diff}");
}

DiffMinAndMaxInArray(maxNumber, minNumber);