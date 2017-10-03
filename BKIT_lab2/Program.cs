using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b,c, d;
            double a1, b1, c1, d1;
            
            Console.WriteLine("Введите ширину и высоту прямоугольника");
            a=Console.ReadLine();
            double.TryParse(a, out a1);
            b = Console.ReadLine();
            double.TryParse(b, out b1);
            Rectangle rect = new Rectangle(a1, b1);
            rect.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Введите сторону квадрата");
            c = Console.ReadLine();
            double.TryParse(c, out c1);
            Square square = new Square(c1);
            square.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Введите радиус окружности");
            d = Console.ReadLine();
            double.TryParse(d, out d1);
            Circle circle = new Circle(d1);
            circle.Print();
            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}        