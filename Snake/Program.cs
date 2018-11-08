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
            
            HorizontalLine lineHor = new HorizontalLine(5,10,8,'$');
            lineHor.Drow();

            VerticalLine lineVer = new VerticalLine(5, 10, 18, '%');
            lineVer.Drow();

            Console.ReadKey();
        }
      
    }
}
