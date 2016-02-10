using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01
{
    interface ICalculator
    {
       double Add(double x, double y);
       double Sub(double x, double y);
       double Mutiply(double x, double y);
       double Divide(double x, double y);
    }
}
