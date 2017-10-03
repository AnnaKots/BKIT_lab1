using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Figure
    {
        public string Type { get; set; }

        public abstract double AreaCalc();

        public override string ToString()
        {
            return this.Type + " имеет площадь " + this.AreaCalc().ToString();
        }
    }
}