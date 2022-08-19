// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();

int x1 = CordAssign("X", "A");
int y1 = CordAssign("Y", "A");
int z1 = CordAssign("Z", "A");
int x2 = CordAssign("X", "B");
int y2 = CordAssign("Y", "B");
int z2 = CordAssign("Z", "B");

// Функция для присваивания в переменные
int CordAssign(string coordName, string pointName)
{
    Console.Write($"Введите координату {coordName} точки {pointName}: ");
    return Convert.ToInt32(Console.ReadLine());
}

// Находим расстояние между двумя точками
double FindDistance(double x1, double x2, double y1, double y2, double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}

double distance = Math.Round(FindDistance(x1, x2, y1, y2, z1, z2), 2);
Console.WriteLine($"Расстояние между точками A и B: {distance}");