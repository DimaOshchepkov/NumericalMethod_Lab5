using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class SimpleIteration
    {
        Function func1;
        Function func2;

        public double begin1 { get; set; }
        public double begin2 { get; set; }
        public double end1 { get; set; }
        public double end2 { get; set; }

        public SimpleIteration(Function f1, Function f2,
            double b1, double e1, double b2, double e2)
        {
            func1 = f1;
            func2 = f2;
            begin1 = b1;
            begin2 = b2;
            end1 = e1;
            end2 = e2;
        }

        public (double, double) Solve(double eps = 1e-5)
        {
            double x0 = (begin1 + end1) / 2;
            double y0 = (begin2 + end2) / 2;

            double x = x0, y = y0;
            int countIter = 0;
            do
            {
                countIter++;
                x0 = x;
                y0 = y;
                x = func1.Map1Value(x0, y0);
                y = func2.Map1Value(x0, y0);

            } while (Eucl(x0, y0, x, y) >= eps);

            Console.WriteLine($"Количество итераций {countIter}");

            return (x, y);
        }
        
        private double Eucl(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - y1, 2) + Math.Pow(x2 - y2, 2));
        }
    }
}

