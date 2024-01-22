bool CheckNull(string? word){
    if (word?.Length == 0)
    {
        Console.WriteLine("Вы должно вводить что нибудь в каждую строку!");
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Выберите какую операцию хотите провести:");
Console.WriteLine("1 - Найти количество символов в строке.");
Console.WriteLine("2 - Заменить подстроку.");
Console.WriteLine("3 - Разделить строку на слова.");
Console.WriteLine("4 - .");

string? button = Console.ReadLine();
switch (button)
{
    case "1":
// Количество символов в строке
        Console.Write("Введите слово: ");
        string? str = Console.ReadLine();
        if (str != null && CheckNull(str))
        {
            return;
        }
        else
        {
            Console.WriteLine($"Символов в этом слове - {str?.Length}");
        }
        break;
    
    case "2":
// Замена подстроки
        Console.Write("Введите слово: ");
        string? str1 = Console.ReadLine();
        Console.Write("Введите слово или подстроку которое хотите заменить: ");
        string? replace = Console.ReadLine();
        Console.Write("Введите слово на которое хотите заменить: ");
        string? text = Console.ReadLine();
        if ((text != null || replace != null) && (CheckNull(replace) || CheckNull(text)))
        {
            return;
        }
        if (str1 != null && replace != null && text != null)
        {
            str = str1.Replace(replace, text);
            Console.WriteLine($"Результат замены - {str}");
        }
        break;
        
    case "3":
// Разделение строки на слова 
        Console.Write("Напишите слова для разделения их на строки: ");
        string? inputText = Console.ReadLine();
        if (inputText != null && CheckNull(inputText))
        {
            return;
        }
        string[]? words = inputText?.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Количество слов которые вы написали " + words?.Length + " ,а именно:");
        if (words != null)
        {
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
        }
        break;
    
    case "4":
        
        break;
        
        default:
            Console.WriteLine("Введите валидное значение!");
            break;
}