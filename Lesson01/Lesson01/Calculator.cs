using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson01;

namespace Lesson01
{
    class Calculator:ICalculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Sub(double x, double y)
        {
            return x - y;
        }

        public double Mutiply(double x, double y)
        {
            return x*y;
        }

        public double Divide(double x, double y)
        {
            return x/y;
        }
    }
}
