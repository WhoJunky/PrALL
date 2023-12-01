using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr9_doter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Для запуска программы нажмите Y, для предварительного выхода нажмите N: ");
                string select_key = Console.ReadLine();
                switch (select_key)
                {
                    case "Y":
                        try
                        {
                            Console.Clear();
                            Console.Title = "Практическая работа №9";
                            Console.WriteLine("Здравствуйте!");
                            Console.Write("Введите число А: ");
                            int A = Convert.ToInt32(Console.ReadLine());
                            int count = 0;
                            Random rnd = new Random();
                            int[] arr = new int [10];
                            for (int i = 0; i < 10; i++)
                            {
                                arr[i] = rnd.Next(-10, 10);
                                Console.WriteLine(arr[i]);
                                if (arr[i] > 0 & arr[i] < A)
                                {
                                    count++;
                                }
                            }
                            Console.WriteLine($"\nЭлементы, значения которых положительны и не превосходят число А: {count}");
                        }
                        catch (FormatException fe) // исключения
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Упс... что-то пошло не так. " + fe.Message);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        catch (Exception ex) // исключения
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Упс... что-то пошло не так. " + ex.Message);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    default:
                        Console.WriteLine("Неизвестная команда.\n");
                        break;
                    case "N":
                        Console.WriteLine("До свидания!");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
