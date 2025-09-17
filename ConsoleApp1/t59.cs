using System;

namespace Task59
{
    public static class A
    {
        public static void Calculate(double x, double y)
        {
            //Уравнение окружности и высчитывание квадратичного расстояния от начала координат к заданной точке
            bool isInCircle = Math.Sqrt(x * x + y * y) <= 1.0;
            Console.WriteLine(isInCircle ? "А)внутри круга" : "А)вне круга");
        }
    }
    public static class B
    {
        public static void Calculate(double x, double y)
        {
            //К предыдущему пункту добавить проверку НЕнахождения в маленькой 0.5 окружности
            bool isInCircle_10 = Math.Sqrt(x * x + y * y) <= 1.0;
            bool noInCircle_05 = Math.Sqrt(x * x + y * y) >= 0.5;
            if (isInCircle_10 && noInCircle_05)
                Console.WriteLine("Б)внутри");
            else Console.WriteLine("Б)снаружи");
        }
    }
    public static class C
    {
        public static void Calculate(double x, double y)
        {
            //просто квадрат
            if (x >= -1 && x <= 1)
                Console.WriteLine((y >= -1 && y <= 1) ? "В)внутри" : "В)снаружи");
            else Console.WriteLine("В)снаружи");

        }
    }
    public static class D
    {
        public static void Calculate(double x, double y)
        {
            // уравнение ромба |x| + |y| ≤ 1
            bool isIn = Math.Abs(x) + Math.Abs(y) <= 1.0;
            Console.WriteLine(isIn ? "Г)внутри" : "Г)снаружи");
        }
    }
    public static class E
    {
        public static void Calculate(double x, double y)
        {
            //ромб сжимается по оси x в 2 раза
            // уравнение ромба |x| + |y| ≤ 1
            bool isIn = Math.Abs(2 * x) + Math.Abs(y) <= 1.0;
            Console.WriteLine((isIn) ? "Д)внутри" : "Д)снаружи");
        }
    }
    public static class F
    {
        public static void Calculate(double x, double y)
        {
            //берём точки по модулю и проверяем 1)слева они ниже уравнения прямой; 2)справа они <= квадратичного расстояния к центру окружности (пункт А)
            y = Math.Abs(y);

            if (x >= -2 && x <= 0)
            {
                double y1 = 0.5 * x + 1;
                Console.WriteLine((y <= y1) ? "Е)внутри" : "Е)снаружи");
            }
            else if (x > 0 && x <= 1)
            {
                bool isInCircle = Math.Sqrt(x * x + y * y) <= 1.0;
                Console.WriteLine((isInCircle) ? "Е)внутри" : "Е)снаружи");
            }
            else Console.WriteLine("Е)снаружи");
        }
    }

    public static class G
    {
        public static void Calculate(double x, double y)
        {
            //тут уже X берём по модулю, чтобы все точки были справа. Они ниже прямой и выше -1
            x = Math.Abs(x);
            if (y >= -1 && y <= 2)
            {
                double y1 = -2 * x + 2;
                Console.WriteLine((y <= y1) ? "Ж)внутри" : "Ж)снаружи");
            }
            else Console.WriteLine("Ж)снаружи");
        }
    }
    public static class H
    {
        public static void Calculate(double x, double y)
        {
            // Аналогично |x|; точки ниже прямой, левее x = 1 и выше y = -2
            x = Math.Abs(x);
            if (y >= 2 && y <= 1 && x <= 1)
            {
                double y1 = x;
                Console.WriteLine((y <= y1) ? "З)внутри" : "З)снаружи");
            }
        }
    }
    public static class I
    {
        public static void Calculate(double x, double y)
        {
            if (x >= 2 && x <= 1 && y >= -1 && y <= 1)
            {
                if (y >= 0 && x >= -1 && x <= 0)
                {
                    double y1 = -x;
                    Console.WriteLine((y <= y1) ? "И)внутри" : "И)снаружи");
                }
                else if (y >= 0 && x >= -1.5 && x < 1)
                {
                    double y1 = 2 * x + 3;
                    Console.WriteLine((y <= y1) ? "И)внутри" : "И)снаружи");
                }
                else if (y < 0)
                {
                    double y1 = 2 * x + 3;
                    double y2 = (1 / 3) * x - (1 / 3);
                    Console.WriteLine((y <= y1 && y >= y2) ? "И)внутри" : "И)снаружи");
                }
            }
            else Console.WriteLine("И)снаружи");

        }
    }
    public static class J
    {
        public static void Calculate(double x, double y)
        {
            //График симм. отн. Ox, поэтому пусть все точки будут положительные
            x = Math.Abs(x);
            if (x < 1)
            {
                double y1 = x;
                Console.WriteLine((y >= y1) ? "К)внутри" : "К)снаружи");
            }
            else Console.WriteLine((y >= 1) ? "К)внутри" : "К)снаружи");
        }
    }
}