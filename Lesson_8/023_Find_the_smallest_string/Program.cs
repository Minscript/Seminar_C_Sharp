// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.Clear();

// Вводные данные
Console.Write("Задайте кол-во строк в массиве: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте кол-во столбцов в массиве: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[row, col];


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
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Red;
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
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
}

void FindSmallerStringInArray(int[,] arr) // Находит
{
    int[,] newArr = arr;
    int minSum = 1000; // Задаём магическое число, которое будет всегда больше чем при возможной сумме строки. Иначе проверка на 71 строке не будет работать.
    int smallString = 0;
    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        int tempSum = 0;

        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            tempSum += arr[i, j];
        }

        Console.Write($"Сумма чисел {i + 1} строки: ");
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine(tempSum);
        Console.ForegroundColor = ConsoleColor.White;

        if (i > 0) // Проверяет, была ли сделана хотябы 1 итерация по строкам
        {
            if (tempSum < minSum) // Является ли сумма меньше, чем предыдущая. Это нужно для будущих проверок по сумме
            {
                minSum = tempSum;
                smallString = i; // Так-же запомнит какой это был столбец
            }
        }
        else
        {
            minSum = tempSum; // Запомнит первую сумму чисел (стандартно: индекс i=0)
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Строка с наименьшей суммой элементов: {smallString + 1}");
}

// Вывод
int[,] newArray = FillArray(array, 0, 9);
PrintArray(newArray);

FindSmallerStringInArray(newArray);