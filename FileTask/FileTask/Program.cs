using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFilePath = "input.txt";
        string outputFilePath = "output.txt";

        try
        {
            CheckFileExists(inputFilePath); 

            string content = ReadFile(inputFilePath);

            int wordCount = CountWords(content);

            WriteResult(outputFilePath, wordCount);
            Console.WriteLine($"Результат записан в файл: {outputFilePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }

    static void CheckFileExists(string filePath)
    {
        if (!File.Exists(filePath))
        {
            CreateFile(filePath);
        }
    }

    static string ReadFile(string filePath)
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            return reader.ReadToEnd();
        }
    }
    static int CountWords(string text)
    {
        string result = "";
        foreach (char smbl in text)
        {
            if (char.IsLetterOrDigit(smbl) || char.IsWhiteSpace(smbl))
            {
                result += smbl;
            }        
        }
        string[] words = result.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }

    static void WriteResult(string filePath, int wordCount)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine($"Количество слов в файле, не считая знаки препинания, символы и все скобки: {wordCount}");
        }
    }

    static void CreateFile(string filePath)
    {
        File.WriteAllText(filePath, "Здесь должен быть ваш текст");
        Console.WriteLine($"Создан новый файл: {filePath}");
    }
}
