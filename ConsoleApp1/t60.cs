using System;

public static class UnderGraph
{
    public static bool Calculate(double x, double y)
    {
        if (x <= 0)
        {
            double y1 = -x;
            return (y <= y1);
        }
        else
        {
            double y2 = -x * x;
            return (y <= y2);
        }
    }

}

namespace Task60
{
    //Без понятия что означает (рис. 1, a-3, е), буду решать по рис. 1 (а) и пусть заштрихованная область будет областью под графиками функций
    public static class A
    {
        public static void Calculate(double x, double y)
        {
            Console.Write("A) ");
            Console.WriteLine(UnderGraph.Calculate(x, y) ? 0 : x);
        }
    }
    public static class B
    {
        public static void Calculate(double x, double y)
        {
            Console.Write("Б) ");
            Console.WriteLine(UnderGraph.Calculate(x, y) ? -3 : y * y);
        }
    }
    public static class C
    {
        public static void Calculate(double x, double y)
        {
            Console.Write("В) ");
            Console.WriteLine(UnderGraph.Calculate(x, y) ? x - y : x * y + 7);
        }
    }
    public static class D
    {
        public static void Calculate(double x, double y)
        {
            Console.Write("Г) ");
            Console.WriteLine(UnderGraph.Calculate(x, y) ? x * x - 1 : Math.Sqrt(Math.Abs(x - 1)));
        }
    }
    public static class E
    {
        public static void Calculate(double x, double y)
        {
            Console.Write("Д) ");
            Console.WriteLine(UnderGraph.Calculate(x, y) ? Math.Sqrt(Math.Abs(x*x - 1)) : x + y);
        }
    }
    public static class F
    {
        public static void Calculate(double x, double y)
        {
            Console.Write("Е) ");
            Console.WriteLine(UnderGraph.Calculate(x, y) ? x + y : x - y);
        }
    }
    
}