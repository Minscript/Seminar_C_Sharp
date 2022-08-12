// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();

//Создаём переменную
Console.Write("Введите любое число от 1 до 7: ");
int week = Convert.ToInt32(Console.ReadLine());

//Проверяем, является ли число днём недели и определяем по нему - выходной ли это день?
void whatWeek(int num){
    Console.Write(week);
    switch (week){
        case 1:
            Console.Write(" - Рабочий день");
            break;
        case 2:
            Console.Write(" - Рабочий день");
            break;
        case 3:
            Console.Write(" - Рабочей недели");
            break;
        case 4:
            Console.Write(" - Рабочий день");
            break;
        case 5:
            Console.Write(" - Короткий рабочий день");
            break;
        case 6:
            Console.Write(" - Выходной");
            break;
        case 7:
            Console.Write(" - Выходной");
            break;
        default:
            Console.Write(" - Не является числом обозначающий день недели!");
            break;
    }
};

//Выполняем "функцию"
whatWeek(week);