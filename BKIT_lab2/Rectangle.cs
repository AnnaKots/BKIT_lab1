using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Rectangle : Figure
        {
            private double height, width;

            public Rectangle(double high, double wide)//конструктор
            {
                this.height = high;
                this.width = wide;
                this.Type = "Прямоугольник";
            }

            public override double AreaCalc()// override отвечает за новую реализацию базового метода
            {
                double Area = (this.width * this.height);
                return Area;
            }

            public void Print()
            {
                Console.WriteLine(this.ToString());//возвращает в виде строки основные праметры фигуры и ее площадь
            }
        }
}