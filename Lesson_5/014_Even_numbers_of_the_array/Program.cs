// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();

int[] array = new int[4];

// Создаём рандом
Random random = new Random();

// Метод рандомизации массива
int[] GetRandom(int[] arr)
{
    int[] inarray = arr;
    for (int i = 0; i < inarray.Length; i++)
    {
        inarray[i] = random.Next(100, 1000);
    }
    return inarray;
}

// Метод поиска чётных чисел в массиве
int FindEven(int[] arr)
{
    int[] inarray = arr;
    int count = 0;
    for (int i = 0; i < inarray.Length; i++)
    {
        if (inarray[i] % 2 == 0)
        {
            count++;
        };
    }
    return count;
}

int[] newArray = GetRandom(array);
int count = FindEven(newArray);

Console.WriteLine($"Задан массив: [{newArray[0]}, {newArray[1]}, {newArray[2]}, {newArray[3]}]");
Console.WriteLine($"Чётных чисел в массиве: {count}");