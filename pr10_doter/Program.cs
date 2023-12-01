using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr10_doter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\nДля запуска программы нажмите Y, для предварительного выхода нажмите N: ");
                string select_key = Console.ReadLine();
                switch (select_key)
                {
                    case "Y":
                        try
                        {
                            Console.Clear();
                            Console.Title = "Практическая работа №10";
                            Console.WriteLine("Здравствуйте!");
                            int m = 3, n = 5;
                            int[,] arr = new int[m, n];
                            Console.WriteLine("Выберите способ заполнения массива: user - ввод с клавиатуры, rnd - случайные числа."); //выбор ввода массива
                            string select_key2 = Console.ReadLine();
                            switch (select_key2)
                            {
                                case "user": //пользовательский ввод
                                    try
                                    {
                                        for (int i = 0; i < m; i++)
                                        {
                                            for (int j = 0; j < n; j++)
                                            {
                                                Console.Write("Введите [" + i + "," + j + "] элемент массива: ");
                                                arr[i, j] = Convert.ToInt32(Console.ReadLine());
                                            }
                                        }

                                        int product = 1; // переменная для хранения произведения ненулевых элементов

                                        // находим произведение ненулевых элементов
                                        for (int i = 0; i < m; i++)
                                        {
                                            for (int j = 0; j < n; j++)
                                            {
                                                if (arr[i, j] != 0) // проверяем, что элемент не равен нулю
                                                {
                                                    product *= arr[i, j];
                                                }
                                            }
                                        }
                                        Console.WriteLine("Произведение ненулевых элементов матрицы: " + product);
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
                                case "rnd":
                                    try
                                    {
                                        Random rnd = new Random();
                                        for (int i = 0; i < m; i++)
                                        {
                                            for (int j = 0; j < n; j++)
                                            {
                                                arr[i, j] = rnd.Next(0, 9);
                                                Console.Write(arr[i, j] + "\t");
                                            }
                                            Console.WriteLine();
                                        }
                                        int product = 1;
                                        // находим произведение ненулевых элементов
                                        for (int i = 0; i < m; i++)
                                        {
                                            for (int j = 0; j < n; j++)
                                            {
                                                if (arr[i, j] != 0) // проверяем, что элемент не равен нулю
                                                {
                                                    product *= arr[i, j];
                                                }
                                            }
                                        }
                                        Console.WriteLine("Произведение ненулевых элементов матрицы: " + product);
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
                            }
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
