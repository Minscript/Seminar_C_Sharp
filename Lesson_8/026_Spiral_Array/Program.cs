// Напишите программу, которая заполнит спирально массив 4 на 4.
Console.Clear();

// Входные данные
int[,] array = new int[4, 4];

// Методы
int[,] FillSpiralArray(int[,] arr) // Двигаемся по массиву и вписываем цифру от 1 до 16
{
    int i = 0;
    int j = 0;

    for (int k = 1; k < arr.GetLength(0) * arr.GetLength(1) + 1; k++)
    {
        arr[i, j] = k;

        if (i <= j + 1 && i + j < arr.GetLength(1) - 1) { j++; }
        else if (i < j && i + j >= arr.GetLength(0) - 1) { i++; }
        else if (i >= j && i + j > arr.GetLength(1) - 1) { j--; }
        else { i--; }
    }
    return arr;
}

void PrintArray(int[,] array) // Выводим в консоль
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write($" 0{array[i, j]} ");
            }
            else
            {

                Console.Write($" {array[i, j]} ");
            }
        }
        Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.White;
}

// Вывод
array = FillSpiralArray(array);
PrintArray(array);