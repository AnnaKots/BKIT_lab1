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
            double a, b, c, dis, skr, ans1, ans2;

            int k = 1;
            do
            {

                Console.WriteLine("\nВведите коэффициенты A, B и С");

                string[] array = new string[3];
                double[] arr = new double[3];

                for (int i = 0; i <= 2; i++)
                {
                    int j = i;
                    array[i] = Console.ReadLine();
                    bool ConvertResult = double.TryParse(array[i], out arr[j]);
                    while (ConvertResult == false)
                    {
                        Console.WriteLine("Введено не число. Попробуйте еще");
                        array[i] = Console.ReadLine();
                        ConvertResult = double.TryParse(array[i], out arr[j]);
                    }
                }

                a = arr[0];
                b = arr[1];
                c = arr[2];

                if ((b * b - 4 * a * c) < 0)
                {
                    dis = b * b - 4 * a * c;
                    Console.WriteLine("Дискриминант равен [" + dis + "] - отрицательный\nНет действительных корней в уравнении");
                }
                else if ((b * b - 4 * a * c) == 0)
                {
                    ans1 = -(b / (2 * a));
                    Console.WriteLine("Дискриминант равен нулю\nУ уравнения 1 корень " + ans1);
                }
                else
                {
                    dis = b * b - 4 * a * c;
                    skr = Math.Sqrt(dis);
                    ans1 = ((-b + skr) / (2 * a));
                    ans2 = ((-b - skr) / (2 * a));
                    Console.WriteLine("Дискриминант равен [" + dis + "]\n1-ый корень уравнения [" + ans1 + "]\n2-ой корень уравнения [" + ans2 + "]");
                }
                Console.ReadKey();
            }
            while (k > 0);
        }
    }
}
