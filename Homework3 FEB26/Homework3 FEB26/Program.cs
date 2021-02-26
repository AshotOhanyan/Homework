using System;

namespace Homework3_FEB26
{

    class Program
    {
        struct Point
        {
            public int x, y;
        }
        static bool doOverlap(Point l1, Point r1, Point l2, Point r2)
        {
            if (l1.x >= r2.x || l2.x >= r1.x)
            {
                return false;
            }

            if (l1.y <= r2.y || l2.y <= r1.y)
            {
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Point l1 = new Point();
            Point r1 = new Point();
            Point l2 = new Point();
            Point r2 = new Point();
            l1.x = Convert.ToInt32(Console.ReadLine());
            l1.y = Convert.ToInt32(Console.ReadLine());
            r1.x = Convert.ToInt32(Console.ReadLine());
            r1.y = Convert.ToInt32(Console.ReadLine());
            l2.x = Convert.ToInt32(Console.ReadLine());
            l2.y = Convert.ToInt32(Console.ReadLine());
            r2.x = Convert.ToInt32(Console.ReadLine());
            r2.y = Convert.ToInt32(Console.ReadLine());
            if (doOverlap(l1, r1, l2, r2))
            {
                Console.WriteLine("Rectangles Overlap");
            }
            else
            {
                Console.WriteLine("Rectangles Don't Overlap");
            }
        }
    }
}
