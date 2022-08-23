Console.Clear();
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int Number_Power(int number_1, int number_2)
{
    int result = 1;
    for (int i = 1; i <= number_2; i++)
    {
        result = result * number_1;
    }
    return result;
}

/* Так как в задаче указанно решить через цикл, то решение будет выглядить так, но было бы правильнее сделать это через:

double result = Math.Pow(number_1, number_2);

При этом сама функция должна будет вернуть тип double.
*/

int result = Number_Power(A, B);

Console.WriteLine($"{A} ^ {B} = {result}");