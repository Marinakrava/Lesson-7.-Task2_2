using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    internal class Program
    {
        static void GetParamsCube(double a, out double v, out double s)
        {
            v = Math.Pow(a, 3);
            s = 6 * Math.Pow(a, 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            double a = Convert.ToDouble(Console.ReadLine());
            double v;
            double s;
            GetParamsCube(a, out v, out s);
            Console.WriteLine("Объем куба = {0:.00}", v);
            Console.WriteLine("Площадь поверхности куба = {0:.00}", s);
            Console.ReadKey();
        }



    }
}
