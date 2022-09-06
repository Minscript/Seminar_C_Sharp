// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Clear();

// Вводные данные

Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] firstArray = new int[row, column];
int[,] secondArray = new int[row, column];

int[,] resultArray = new int[row, column];

// Методы
int[,] FillArray(int[,] arr) // Заполним массив рандомом (ручками долго указывать и тестировать)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(1, 9);
        }
    }
    return arr;
}

void PrintArray(int[,] array) // Вывод массива в консоль
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ProductMatrix(int[,] firstArr, int[,] secondArr, int row, int col) // Производим произведение двух матриц
{
    int[,] resultArr = new int[row, col];
    for (int i = 0; i < firstArr.GetLength(0); i++)
    {
        for (int j = 0; j < secondArr.GetLength(1); j++)
        {
            resultArr[i, j] = 0;
            for (int k = 0; k < firstArr.GetLength(1); k++)
            {
                resultArr[i, j] += firstArr[i, k] * secondArr[k, j];
            }
        }
    }
    return resultArr;
}

// Вывод

if (firstArray.GetLength(0) != secondArray.GetLength(1)) // Проверка правильности ввода
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Количество столбцов матрицы должно быть равно количеству строк!");
    Console.ForegroundColor = ConsoleColor.White;
    return;
}

Console.WriteLine();

firstArray = FillArray(firstArray);
Console.WriteLine("Первая матрица: ");
Console.ForegroundColor = ConsoleColor.Blue;
PrintArray(firstArray);
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine();

secondArray = FillArray(secondArray);
Console.WriteLine("Вторая матрица: ");
Console.ForegroundColor = ConsoleColor.Cyan;
PrintArray(secondArray);
Console.ForegroundColor = ConsoleColor.White;


resultArray = ProductMatrix(firstArray, secondArray, row, column);

Console.WriteLine();
Console.WriteLine("Произведение двух матриц: ");
Console.ForegroundColor = ConsoleColor.Green;
PrintArray(resultArray);
Console.ForegroundColor = ConsoleColor.White;