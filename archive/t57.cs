// namespace MyApp
// {
//     public static class Task57
//     {
//         public static void F()
//         {
//             int x = int.Parse(Console.ReadLine());
//             // Пункт а
//             int y;
//             if (x >= -2 && x < 2)
//             {
//                 y = x * x;
//             }
//             else
//             {
//                 y = 4;
//             }
//             ;
//             Console.WriteLine($"a: {y}");

//             // Пункт б
//             if (x <= 2)
//             {
//                 y = x * x + 4 * x + 5;
//             }
//             else
//             {
//                 y = 1 / (x * x + 4 * x + 5);
//             }
//             ;
//             Console.WriteLine($"б: {y}");

//             // Пункт в
//             if (x <= 0)
//             {
//                 y = 0;
//             }
//             else if (x > 0 && x <= 1)
//             {
//                 y = x;
//             }
//             else
//             {
//                 y = (int)Math.Pow(x, 4);
//             }
//             ;
//             Console.WriteLine($"в: {y}");

//             // Пункт г
//             if (x <= 0)
//             {
//                 y = 0;
//             }
//             else if (x > 0 && x <= 1)
//             {
//                 y = x * x - x;
//             }
//             else
//             {
//                 y = (int)(x * x - Math.Sin(Math.PI * x * x));
//             }
//             ;
//             Console.WriteLine($"г: {y}");
//         }
//     }

// }
