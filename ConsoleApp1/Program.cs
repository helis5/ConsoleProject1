using System;
namespace Task58
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите X, Y:");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Задание 58:");
            Task58.A.Calculate(x);
            Task58.B.Calculate(x);
            Task58.C.Calculate(x);
            Task58.D.Calculate(x);

            Console.WriteLine("Задание 59:");
            Task59.A.Calculate(x, y);
            Task59.B.Calculate(x, y);
            Task59.C.Calculate(x, y);
            Task59.D.Calculate(x, y);
            Task59.F.Calculate(x, y);
            Task59.G.Calculate(x, y);
            Task59.H.Calculate(x, y);
            Task59.I.Calculate(x, y);
            Task59.J.Calculate(x, y);
        }
    }
}