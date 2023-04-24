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

        SimpleIteration(Function f1, Function f2,
            double b1, double e1, double b2, double e2)
        {
            func1 = f1;
            func2 = f2;
            begin1 = b1;
            begin2 = b2;
            end1 = e1;
            end2 = e2;
        }

    }
}

