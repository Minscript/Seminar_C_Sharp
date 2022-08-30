Console.Clear();
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[,] ratio = new double[2, 2];
double[] point = new double[2];

// Пользователь вводит данные
void InputCoefficients()
{
    for (int i = 0; i < ratio.GetLength(0); i++)
    {
        Console.WriteLine($"Введите коэффициент {i + 1}-ой прямой:");
        for (int j = 0; j < ratio.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"k: ");
            else Console.Write($"b: ");
            ratio[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

// Находим точку пересечения
double[] FindPointInterselection(double[,] ratio)
{
    point[0] = (ratio[1, 1] - ratio[0, 1]) / (ratio[0, 0] - ratio[1, 0]);
    point[1] = point[0] * ratio[0, 0] + ratio[0, 1];
    return point;
}

// Выводит ответ на экран
void PrintCoordPoint(double[,] ratio)
{
    if (ratio[0, 0] == ratio[1, 0] && ratio[0, 1] == ratio[1, 1])
    {
        Console.Write($"\nПрямые совпадают!");
    }
    else if (ratio[0, 0] == ratio[1, 0] && ratio[0, 1] != ratio[1, 1])
    {
        Console.Write($"\nПрямые параллельны!");
    }
    else
    {
        FindPointInterselection(ratio);
        Console.Write($"\nТочка пересечения прямых: (X: {point[0]}, Y: {point[1]})");
    }
}

InputCoefficients();
PrintCoordPoint(ratio);