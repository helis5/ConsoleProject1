using System;

namespace Task58
{
    public static class A
    {
        public static void Calculate(double x)
        {
            Console.WriteLine($"a: {((x < 0) ? -x : -(x * x))}");
        }
    }

    public static class B
    {
        public static void Calculate(double x)
        {
            double y;
            if (x < -1) y = 1 / (x * x);
            else if (x >= -1 && x <= 2) y = x * x;
            else y = 4;
            Console.WriteLine($"б: {y}");
        }
    }
    public static class C
    {
        public static void Calculate(double x)
        {
            Console.WriteLine($"в: {((x < 0) ? Math.Abs(-x - 1) : Math.Abs(x - 1))}");
        }
    }
    public static class D
    {
        public static void Calculate(double x)
        {
            double y;
            if (x < 0) y = -x;
            else if (x >= 0 && x <= 1) y = x;
            else if (x > 1 && x < 2) y = 1;
            else y = -2 * x + 5;

            Console.WriteLine($"г: {y}");
        }
    }
}