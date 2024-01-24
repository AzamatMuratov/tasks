using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread thread1 = new Thread(DoWork);
        Thread thread2 = new Thread(DoWork);
        Thread thread3 = new Thread(DoWork);

        thread1.Start("Поток 1");
        thread2.Start("Поток 2");
        thread3.Start("Поток 3");

        thread1.Join();
        thread2.Join();
        thread3.Join();

        Console.WriteLine("Все потоки завершили работу");
    }

    static void DoWork(object? threadNameObject)
    {
        string threadName = threadNameObject?.ToString() ?? "Неизвестный поток";

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"{threadName}: Выполняется итерация {i}");

            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            Thread.Sleep(randomNumber);

            Console.WriteLine($"{threadName}: Завершение итерации {i} после {randomNumber} мс");
        }
    }
}