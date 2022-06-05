// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
string[] DataArray(string str)
{
    Console.WriteLine(str);
    str = Console.ReadLine().Replace('.', ',');
    char[] separators = new char[] { ' ' };
    string[] subs = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return subs;
}
void PositiveNumbers(string[] array)
{
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((double.TryParse(array[i], out double positive)) && positive > 0)
            n = n + 1;
    }
    Console.WriteLine($"Количество введенных чисел пользователем больше 0 равно: {n}");
}
string[] result = DataArray("Введите числа через пробел:");
PositiveNumbers(result);


