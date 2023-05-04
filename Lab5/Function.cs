using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Function
    {
        public Func<double, double, double> MyFunc;
        private Func<double, double, double> Map1;
        private Func<double, double, double> DMap1;

        public double eps { get; set; }


        public Function(Func<double, double, double> func,
            Func<double, double, double> map1,
            Func<double, double, double> dMap1, double eps = 1e-5)
        {
            this.MyFunc = func;
            this.Map1 = map1;
            this.DMap1 = dMap1;
            this.eps = eps;
        }

        public Function(Function other)
        {
            this.MyFunc = other.MyFunc;
            this.Map1 = other.Map1;
            this.DMap1 = other.DMap1;
            this.eps = other.eps;
        }

        public double FuncValue(double x, double y) => MyFunc(x, y);
        public double Map1Value(double x, double y) => Map1(x, y);
        public double DMap1Value(double x, double y) => DMap1(x, y);      

        public static double MaximumInTheInterval(Func<double, double> func, double begin, double end, double eps = 1e-2)
        {
            double max = func(begin);
            while (begin < end)
            {
                max = Math.Max(max, func(begin));
                begin += eps;
            }
            return max;
        }

        public static double MinimumInTheInterval(Func<double, double> func, double begin, double end, double eps = 1e-3)
        {
            double min = func(begin);
            while (begin < end)
            {
                min = Math.Min(min, func(begin));
                begin += eps;
            }
            return min;
        }
    }
}
