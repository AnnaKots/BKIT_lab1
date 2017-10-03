using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Square:Rectangle
    {
        public Square(double size):base(size, size)
        {
            this.Type = "Квадрат";
        }
    }
}
