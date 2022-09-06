// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.Clear();

// Вводные данные
Console.Write("Задайте размер квадратного массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[size, size];

// Методы
int[,] FillArray(int[,] arr, int min, int max) // Заполняем массив
{
    int[,] newArr = arr;
    Random random = new Random();

    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            newArr[i, j] = random.Next(min, max + 1);
        }
    }

    return newArr;
}

void PrintArray(int[,] arr) // Выводим массив в консоль
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int[,] SortArray(int[,] arr) // Сортируем массив по убыванию
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1]) // Меняем местами
                {
                    int temp = arr[i, k];
                    arr[i, k] = arr[i, k + 1];
                    arr[i, k + 1] = temp;
                }
            }
        }
    }
    return arr;
}

// Вывод
int[,] newArray = FillArray(array, 0, 9);

Console.WriteLine("Сгенерирован массив:");
Console.ForegroundColor = ConsoleColor.Red;
PrintArray(newArray);

Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.White;

int[,] sortedArray = SortArray(newArray);

Console.WriteLine("Сортированный массив:");
Console.ForegroundColor = ConsoleColor.Green;
PrintArray(sortedArray);

Console.ForegroundColor = ConsoleColor.White;