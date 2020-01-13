using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLines : Figure
    {
        public VerticalLines(int yDown, int yUp, int x, char sym)
        {
            for (int y = yDown; y <= yUp; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }   
}
