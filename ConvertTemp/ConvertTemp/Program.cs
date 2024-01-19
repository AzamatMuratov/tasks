bool isValid(string? input, out double number)
{
    if (double.TryParse(input, out number))
    {
        return true;
    }
    else
    {
        Console.WriteLine("Введите корректное число");
        return false;
    }
}
Console.Write("Введите температуру: ");
double temperture;
char? temperatureUnit;
string? a1 = Console.ReadLine();
if (isValid(a1, out temperture))
{
    Console.Write("Введите единицу измерения: ");
    string? input = Console.ReadLine();
    if (!string.IsNullOrEmpty(input) && input.Length == 1)
    {
        temperatureUnit = input[0];
        switch (temperatureUnit)
        {
            case 'C':
                temperture = temperture * 9 / 5 + 32;
                Console.WriteLine($"Значение после конвертировния из Цельсия в Фаренгейт = {temperture}");
                break;
            case  'F':
                temperture = (temperture - 32) * 5 / 9;
                Console.WriteLine($"Значение после конвертировния из Фаренгейта в Цельсий = {temperture}");
                break;
            default:
                Console.WriteLine("Неизвестная единица измерения");
                break;
        }
    }
    else
    {
        Console.WriteLine("Введите правильную едицину измерения 'C' или 'F'");
    }
}


