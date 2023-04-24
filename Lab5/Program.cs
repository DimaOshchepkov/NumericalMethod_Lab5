using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> f1 = (x, y) => Math.Sin(y - 1) + x - 1.3;
            Func<double, double, double> f2 = (x, y) => Math.Sin(x + 1) + y - 0.8;

            Func<double, double, double> map1 = (x, y) => 1.3 - Math.Sin(y - 1);
            Func<double, double, double> map2 = (x, y) => 0.8 - Math.Sin(x + 1);

            Func<double, double, double> dMap1 = (x, y) => 1.3 - Math.Sin(y - 1);
            Func<double, double, double> dMap2 = (x, y) => 0.8 - Math.Sin(x + 1);

            Function myFunc1 = new Function(f1, map1, dMap1);
            Function myFunc2 = new Function(f2, map2, dMap2);


        }
    }
}
