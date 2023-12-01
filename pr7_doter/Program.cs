using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Здравствуйте!");
        try
        {
            int count = 0;
            Console.WriteLine("Введите 10 случайных чисел");
            for (int i = 1; i <= 10; i++)
            {
                int numbers = Convert.ToInt32(Console.ReadLine());
                if (Math.Abs(numbers) > 5)
                {
                    count++;
                }
            }
            Console.WriteLine($"Числа, большие по модулю, чем 5: {count}");
            Console.ReadKey();
        }
        catch (FormatException fe)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Что-то пошло не так... " + fe.Message);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Что-то пошло не так..." + ex.Message);
        }
        Console.ReadKey();
    }
}
