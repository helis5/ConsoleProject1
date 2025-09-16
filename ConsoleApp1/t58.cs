using System;

namespace Task58
{
    public static class A
    {
        public static void Calculate(int x)
        {
            int y;
            if (x < 0)
            {
                y = -x;
            }
            else
            {
                y = -(x * x);
            }
            Console.WriteLine($"a: {y}");
        }
    }

    public static class B
    {
        public static void Calculate(int x)
        {
            int y;
            if (x < -1)
            {
                y = 1 / (x * x);
            }
            else if (x >= -1 && x <= 2)
            {
                y = x * x;
            }
            else
            {
                y = 4;
            }
            Console.WriteLine($"б: {y}");
        }
    }
    public static class C
    {
        public static void Calculate(int x)
        {
            int y;
            if (x < 0)
            {
                y = Math.Abs(-x - 1);
            }
            else
            {
                y = Math.Abs(x - 1);
            }

            Console.WriteLine($"в: {y}");
        }
    }
    public static class D
    {
        public static void Calculate(int x)
        {
            int y;
            if (x < 0)
            {
                y = -x;
            }
            else if (x >= 0 && x <= 1)
            {
                y = x;
            }
            else if (x > 1 && x < 2)
            {
                y = 1;
            }
            else
            {
                y = -2 * x + 5;
            }

            Console.WriteLine($"г: {y}");
        }
    }
}