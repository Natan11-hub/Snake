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
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80,25);
            Console.SetWindowSize(80,25);

            HorizontalLines upLine = new HorizontalLines(0,78,0,'+');
            HorizontalLines downLine = new HorizontalLines(0, 78, 24, '+');
            VerticalLines leftLine = new VerticalLines(0,24,0,'+');
            VerticalLines rightLine = new VerticalLines(0, 24, 78, '+');

            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            Console.ReadLine();
        }
    }
}
