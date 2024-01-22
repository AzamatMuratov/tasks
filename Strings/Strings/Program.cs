bool CheckNull(string? word){
    if (word?.Length == 0)
    {
        Console.WriteLine("Вы должно вводить значение в каждую строку!");
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
Console.WriteLine("4 - Вставка строки.");
Console.WriteLine("5 - Смена регистра.");


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
        Console.WriteLine("Количество слов которые вы написали " + words?.Length + ", а именно:");
        if (words != null)
        {
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
        }
        break;

    // Вставка строки
    case "4":
        Console.Write("Введите слово: ");
        string? word1 = Console.ReadLine();
        if (CheckNull(word1))
        {
            return;
        }
        Console.WriteLine("В каком месте добавить?");
        Console.WriteLine("1 - в начале");
        Console.WriteLine("2 - в конце");
        Console.WriteLine("3 - выбрать индекс");
        string? choose = Console.ReadLine();
        if (CheckNull(choose))
        {
            return;
        }
        Console.Write("Введите слово которое хотите добавить: ");
        string? pasteWord1 = Console.ReadLine();
        if (CheckNull(pasteWord1))
        {
            return;
        }
        switch (choose)
        {
            case "1":
                if (pasteWord1 != null)
                {
                    word1 = word1?.Insert(0, pasteWord1);
                    Console.WriteLine($"Результат после вставки строки - {word1}");
                }
                break;
            case "2":
                if (pasteWord1 != null)
                {
                    word1 = word1?.Insert(word1.Length - 1, pasteWord1);
                    Console.WriteLine($"Результат после вставки строки - {word1}");
                }
                break;
            case "3":
                Console.Write("Начиная с какого индекса вставить текст - ");
                var number = Console.ReadLine();
                if (int.TryParse(number, out int result))
                {
                    if (result > word1?.Length)
                    {
                        Console.WriteLine("Неправильный индекс!");
                        break;
                    }
                    if (pasteWord1 != null)
                    {
                        word1 = word1?.Insert(result, pasteWord1);
                        Console.WriteLine($"Результат после вставки строки - {word1}");
                    }
                }
                else
                {
                    Console.WriteLine("Невозможно преобразовать строку в число.");
                }
                break;
            default:
                Console.WriteLine("Выберите валидное значение!");
                break;
        }
        break;

    case "5":
        Console.WriteLine("Введите слово: ");
        string? wordForRegister = Console.ReadLine();
        if (CheckNull(wordForRegister))
        {
            return;
        } 
        Console.WriteLine("В какой регистр поменять слово?"); 
        Console.WriteLine("1 - Верхний");
        Console.WriteLine("2 - Нижний");
    string? chooseBtn = Console.ReadLine();
    switch (chooseBtn)
    {
        case "1":
            Console.WriteLine(wordForRegister?.ToUpper());
            break;
        case "2":
            Console.WriteLine(wordForRegister?.ToLower());
            break;
        default:
            Console.WriteLine("Введите валидное значение!");
            break;
    }
        break;
    
        default:
            Console.WriteLine("Введите валидное значение!");
            break;
}