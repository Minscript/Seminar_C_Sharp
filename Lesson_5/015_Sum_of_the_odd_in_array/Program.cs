Console.Clear();
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[10];

// Создаём рандом
Random random = new Random();

// Метод рандомизации массива
int[] GetRandom(int[] arr)
{
    int[] inarray = arr;
    for (int i = 0; i < inarray.Length; i++)
    {
        inarray[i] = random.Next(1, 100);
    }
    return inarray;
}

int[] newArray = GetRandom(array);

int SumOdd(int[] arr)
{
    int result = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        result = result + arr[i];
    }
    return result;
}

// Метод вывода массива
void PrintArray(int[] arr)
{
    Console.Write("Массив чисел: [");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i + 1 < arr.Length)
        {
            Console.Write($"{arr[i]}, ");
        }
        else
        {
            Console.WriteLine($"{arr[i]}]");
        }
    }
}

void PrintOddArray(int[] arr)
{
    Console.Write("Считаем следующие числа: ");
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        if (i + 1 < arr.Length)
        {
            Console.Write($"{arr[i]} + ");
        }
        else
        {
            Console.WriteLine($"{arr[i]}\n");
        }
    }
}

PrintArray(newArray);

PrintOddArray(newArray);

int result = SumOdd(newArray);

Console.Write($"Сумма нечётных элементов массива: {result}");