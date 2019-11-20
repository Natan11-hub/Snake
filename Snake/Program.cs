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

            VerticalLines vertical = new VerticalLines(5,12,6,'+');
            vertical.Drow();

            HorizontalLines horizontalLines = new HorizontalLines(6,10,4,'%');
            horizontalLines.Drow();

            Console.ReadLine();
        }
    }
}
