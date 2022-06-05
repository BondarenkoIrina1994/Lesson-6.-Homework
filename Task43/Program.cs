// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
double CheckingForCorrectnes(string str)
{
    while (true)
    {
        Console.WriteLine(str);
        string num = Console.ReadLine();
        if (double.TryParse(num, out double number) == false)
            Console.WriteLine("Вы ввели некорректное значение. Для корректной работы программы введите число!!!");
        else
            return number;
    }
}
void IntersectionPoint(double a1, double b1, double a2, double b2)
{
    if (a1 == a2)
        Console.WriteLine($"Прямые y={a1}x+{b1} и y={a2}x+{b2} параллельны и не пересекаются!!!");
    else
    {
        double x = (b2 - b1) / (a1 - a2);
        double y = a1 * x + b1;
        Console.WriteLine($"Точка пересечения прямых y={a1}x+{b1} и y={a2}x+{b2}: ({x},{y}) ");
    }
}
double k1 = CheckingForCorrectnes("Введите коэффициент k1: ");
double b1 = CheckingForCorrectnes("Введите коэффициент b1: ");
double k2 = CheckingForCorrectnes("Введите коэффициент k2: ");
double b2 = CheckingForCorrectnes("Введите коэффициент b2: ");
IntersectionPoint(k1, b1, k2, b2);
