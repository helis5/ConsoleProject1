using System;
using System.Security.Cryptography.X509Certificates;

namespace Task59
{
    public static class A
    {
        public static void Calculate(int x, int y)
        {
            //Уравнение окружности и высчитывание квадратичного расстояния от начала координат к заданной точке
            bool isInCircle = (x * x + y * y) <= 1.0;
            Console.WriteLine(isInCircle ? "А)внутри круга" : "А)вне круга");
        }
    }
    public static class B
    {
        public static void Calculate(int x, int y)
        {
            //К предыдущему пункту добавить проверку НЕнахождения в маленькой 0.5 окружности
            bool isInCircle_10 = Math.Sqrt(x * x + y * y) <= 1.0;
            bool noInCircle_05 = Math.Sqrt(x * x + y * y) >= 0.5;
            if (isInCircle_10 && noInCircle_05)
            {
                Console.WriteLine("Б)внутри");
            }
            else
            {
                Console.WriteLine("Б)снаружи");
            }
        }
    }
    public static class C
    {
        public static void Calculate(int x, int y)
        {
            //просто квадрат
            if (x >= -1 && x <= 1)
            {
                Console.WriteLine((y >= -1 && y <= 1) ? "В)внутри" : "В)снаружи");
            } else Console.WriteLine("В)снаружи");

        }
    }
    public static class D
    {
        public static void Calculate(int x, int y)
        {
            // уравнение ромба |x| + |y| ≤ 1
            bool isIn = Math.Abs(x) + Math.Abs(y) <= 1.0;
            Console.WriteLine(isIn ? "Г)внутри" : "Г)снаружи");
        }
    }
    public static class E
    {
        public static void Calculate(int x, int y)
        {
            //ромб сжимается по оси x в 2 раза
            // уравнение ромба |x| + |y| ≤ 1
            bool isIn = Math.Abs(2 * x) + Math.Abs(y) <= 1.0;
            Console.WriteLine((isIn) ? "Д)внутри" : "Д)снаружи");
        }
    }
    public static class F
    {
        public static void Calculate(int x, int y)
        {
            //берём точки по модулю и проверяем 1)слева они ниже уравнения прямой; 2)справа они <= квадратичного расстояния к центру окружности (пункт А)
            y = Math.Abs(y);

            if (x >= -2 && x <= 0)
            {
                double y1 = 0.5 * x + 1;
                Console.WriteLine((y < y1) ? "Е)внутри" : "Е)снаружи");
            }
            else if (x > 0 && x <= 1)
            {
                bool isInCircle = Math.Sqrt(x * x + y * y) <= 1.0;
                Console.WriteLine((isInCircle) ? "Е)внутри" : "Е)снаружи");
            }
            else
            {
                Console.WriteLine("Е)снаружи");
            }
        }
    }

    public static class G
    {
        public static void Calculate(int x, int y)
        {
            //тут уже X берём по модулю, чтобы все точки были справа. Они ниже прямой и выше -1
            x = Math.Abs(x);
            if (y >= -1 && y <= 2)
            {
                double y1 = -2 * x + 2;
                Console.WriteLine((y < y1) ? "Ж)внутри" : "Ж)снаружи");
            }
            else
            {
                Console.WriteLine("Ж)снаружи");
            }
        }
    }
    public static class H
    {
        public static void Calculate(int x, int y)
        {
            // Аналогично |x|; точки ниже прямой, левее x = 1 и выше y = -2
            x = Math.Abs(x);
            if (y >= 2 && y <= 1 && x <= 1)
            {
                double y1 = x;
                Console.WriteLine((y < y1) ? "З)внутри" : "З)снаружи");
            }
        }
    }
}