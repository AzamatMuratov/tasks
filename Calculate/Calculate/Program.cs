double a, b, result;
char? oper; 

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

Console.Write("Введите первое число:");
string? a1 = Console.ReadLine();
if (isValid(a1, out a))
{
    Console.Write("Введите оператор:");
    string? operInput = Console.ReadLine();
    if (!string.IsNullOrEmpty(operInput) && operInput.Length == 1)
    {
        oper = operInput[0];
        Console.Write("Введите второе число:");
        string? b1 = Console.ReadLine();
        if (isValid(b1, out b))
        {
            if (b == 0 && oper == '/')
            {
                Console.WriteLine("Ошибка: Нельзя делить на ноль");
            }
            else
            {
                switch (oper)
                {
                    case '+':
                        result = a + b;
                        Console.WriteLine($"Результат равен - {result}");
                        break;
                    case '-':
                        result = a - b;
                        Console.WriteLine($"Результат равен - {result}");
                        break;
                    case '*':
                        result = a * b;
                        Console.WriteLine($"Результат равен - {result}");
                        break;
                    case '/':
                        result = a / b;
                        Console.WriteLine($"Результат равен - {result}");
                        break;
                    default:
                        Console.WriteLine("Неизвестный оператор.");
                        break;
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Ошибка: Введенный оператор не является корректным символом");
    }
}