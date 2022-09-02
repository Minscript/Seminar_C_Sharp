Console.Clear();
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateFilledArray(int str, int col, int min, int max) //Создаёт массив и заполняет его числами
{
    int[,] arr = new int[str, col];
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(min, max + 1);
        }
    }
    return arr;
}

void FindArithmeticMean(int[,] arr) //Находит среднее арифметическое столбоц (вертикально) и выводит на экран
{
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            temp += arr[j, i];
        }
        temp = temp * arr.GetLength(0);
        Console.WriteLine($"{i + 1} столбец: {temp}");
    }
}

void PrintArray(int[,] arr) //Показывает массив
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = CreateFilledArray(str: 5, col: 5, min: 0, max: 9);
PrintArray(array);
FindArithmeticMean(array);