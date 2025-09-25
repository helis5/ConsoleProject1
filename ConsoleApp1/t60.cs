using System;

namespace Task60
{
    public static class A
    {
        public static void Calculate(double x, double y)
        {
            Console.Write("A) ");
            if (y >= 0)
            {
                bool isInCircle_10 = Math.Sqrt(x * x + y * y) <= 1.0;
                bool noInCircle_05 = Math.Sqrt(x * x + y * y) >= 0.5;
                if (isInCircle_10 && noInCircle_05) Console.WriteLine("Да; 0");
                else Console.WriteLine($"Нет; {x}");
            }
            else Console.WriteLine($"Нет; {x}");
        }
    }
    public static class B
    {
        public static void Calculate(double x, double y)
        {
            Console.Write("Б) ");
            if (y <= x / 2)
            {
                bool isInCircle_10 = Math.Sqrt(x * x + y * y) <= 1.0;
                if (isInCircle_10) Console.WriteLine("-3");
                else Console.WriteLine($"Нет; {y * y}");
            }
            else Console.WriteLine($"Нет; {y * y}");
        }
    }
    public static class C
    {
        public static void Calculate(double x, double y)
        {
            Console.Write("В) ");
            bool isInCircle_10 = Math.Sqrt(x * x + Math.Pow(y - 1, 2)) <= 1.0;
            if (isInCircle_10 && (y <= 1 - x * x))
                Console.WriteLine($"Да; {x - y}");
            else Console.WriteLine($"Нет; {x * y + 7}");

        }
    }
    public static class D
    {
        public static void Calculate(double x, double y)
        {
            Console.Write("Г) ");
            if (y >= 0)
            {
                if (x <= 0) 
                {
                    bool isInCircle_10 = Math.Sqrt(x * x + y * y) <= 1.0;
                    if (isInCircle_10) Console.WriteLine($"{x * x - 1}");
                    else Console.WriteLine($"{Math.Sqrt(Math.Abs(x - 1))}");
                }
                else if (x > 0)
                {
                    bool isInCircle_10 = Math.Sqrt(x * x + y * y) <= 1.0;
                    bool noInCircle_03 = Math.Sqrt(x * x + y * y) >= 0.3;
                    if (isInCircle_10 && noInCircle_03) Console.WriteLine($"Да, {x * x - 1}");
                    else Console.WriteLine($"Нет, {Math.Sqrt(Math.Abs(x - 1))}");
                }
            }
        }
    }
    public static class E
    {
        public static void Calculate(double x, double y)
        {
            Console.Write("Д) ");
            x = Math.Abs(x);
            bool isInCircle_10 = Math.Sqrt(x * x + y * y) <= 1.0;
            if (y >= x && isInCircle_10)
                Console.WriteLine($"Да, {Math.Sqrt(Math.Abs(x * x - 1))}");
            else
                Console.WriteLine($"Нет, {x + y}");
        }
    }
    public static class F
    {
        public static void Calculate(double x, double y)
        {
            Console.Write("Е) ");
            if (y >= x * x && y <= Math.Exp(x) && y <= Math.Exp(-x))
                Console.WriteLine($"Да, {x + y}");
            else
                Console.WriteLine($"Да, {x - y}");
        }
    }
    
}