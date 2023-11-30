using System;
namespace pr5_dotir;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Здравствуйте!");
        Console.WriteLine("Введите стороны 1-го треугольника: ");
        int a1 = Convert.ToInt32(Console.ReadLine());
        int b1 = Convert.ToInt32(Console.ReadLine());
        int c1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите стороны 2-го треугольника: ");
        int a2 = Convert.ToInt32(Console.ReadLine());
        int b2 = Convert.ToInt32(Console.ReadLine());
        int c2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        double p1 = (a1 + b1 + c1) / 2;
        double p2 = (a2 + b2 + c2) / 2;
        double S1 = Math.Sqrt(p1 * (p1 - a1) * (p1 - b1) * (p1 - c1));
        Console.WriteLine($"Площадь 1-го треугольника : {S1}");
        double S2 = Math.Sqrt(p2 * (p2 - a2) * (p2 - b2) * (p2 - c2));
        Console.WriteLine($"Площадь 2-го треугольника : {S2}");
        Console.WriteLine();
        if(S1 == S2) Console.WriteLine("Площади треугольников равны.");
        else Console.WriteLine("Площади треугольников не равны.");
        Console.ReadKey();
    }
}