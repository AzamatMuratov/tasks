using System;
using System.Collections.Generic;

class Program
{
    static List<string> tasks = new List<string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Добавить новую задачу");
            Console.WriteLine("2. Вывести список задач");
            Console.WriteLine("3. Отметить задачу как выполненная");
            Console.WriteLine("4. Удалить задачу");
            Console.WriteLine("5. Выход");
            
            
            string? choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    if (tasks.Count < 0)
                    {
                        Console.WriteLine("Список задач пуст");
                        break;
                    }
                    ShowTasks();
                    break;
                case "3":
                    if (tasks.Count == 0)
                    {
                        Console.WriteLine("Нет задач, которые можно отметить как выполненные!");
                        break;
                    }
                    Console.WriteLine("Выберите задачу которую хотите отметить выполненной");
                    ShowTasks();
                    var btnChoose = Console.ReadLine();
                    if (int.TryParse(btnChoose, out int result1))
                    {
                        if (result1 > tasks.Count)
                        {
                            Console.WriteLine("Вы ввели цифру превышающую число задач");
                            break;
                        }
                        else
                        {
                            tasks[result1-1] = tasks[result1-1] + " - ВЫПОЛНЕНО";
                            Console.WriteLine("Задача успешно отмечена");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Неверный ввод!");
                        break;
                    }
                    
                case "4":
                    if (tasks.Count == 0)
                    {
                        Console.WriteLine("Нет задач, которые можно удалить!");
                        break;
                    }
                    Console.WriteLine("Выберите задачу которую хотите удалить");
                    ShowTasks();
                    var number = Console.ReadLine();
                    if (int.TryParse(number, out int result))
                    {
                        if (result > tasks.Count)
                        {
                            Console.WriteLine("Вы ввели цифру превышающую число задач");
                            break;
                        }
                        else
                        {
                            tasks.RemoveAt(result-1);
                            Console.WriteLine("Задача успешно удалена");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Неверный ввод!");
                        break;
                    }
                    
                case "5": 
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Пожалуйста, выберите действие из списка.");
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.Write("Введите новую задачу: ");
        string? task = Console.ReadLine();
        if (CheckNull(task) || task == null)
        {
            return;
        }
        tasks.Add(task);
        Console.WriteLine("Задача добавлена успешно!");
    }

    static void ShowTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Список задач пуст");
            return;
        }
        Console.WriteLine("Список задач:");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i]}");
        }
    }
    static bool CheckNull(string? word){
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
}