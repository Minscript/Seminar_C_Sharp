Console.Clear();
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateArray()
{
    Console.Write("Задайте кол-во строк: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Задайте кол-во столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] arr = new double[m, n];
    Console.WriteLine();
    return arr;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}   ");
        }
        Console.WriteLine();
    }
}

double[,] FillArrayRandomNumber(double[,] arr)
{
    double[,] newArr = new double[arr.GetLength(0), arr.GetLength(1)];
    Random random = new Random();

    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            newArr[i, j] = random.NextDouble() * random.Next(-10, 10); // Рандомим число от -10 до 10 с плавующей точкой
            newArr[i, j] = Math.Round(newArr[i, j], 1); // Убираем лишние точки после запятой
        }
    }
    return newArr;
}

double[,] array = CreateArray();
array = FillArrayRandomNumber(array);
PrintArray(array);