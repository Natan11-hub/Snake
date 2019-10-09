using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '#');
            p1.Draw();


            Point p2 = new Point(2,7,'*');
            p2.Draw();

            Point p3 = new Point(5, 12, '@');
            p3.Draw();

            Point p4 = new Point(10, 3, '&');
            p4.Draw();

            List<Point> valList = new List<Point>();

            valList.Add(p1);
            valList.Add(p2);
            valList.Add(p3);
            valList.Add(p4);

            Console.ReadLine();
        }
    }
}
