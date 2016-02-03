using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculator calc = new Calculator();
            while (true) { 
            Console.WriteLine("Hello please enter first operand:");
            var op1 = Console.ReadLine();
            var x = 0.0;
            if (op1 != null)
            {
                x = double.Parse(op1);
            }
            Console.WriteLine("Hello please enter operator +, -, *, /:");
            var operatior = Console.ReadLine();
            Console.WriteLine("Hello please enter second operand:");
            var op2 = Console.ReadLine();
            var y = 0.0;
            if (op2 != null)
            {
                y = double.Parse(op2);
            }
            double result = 0.0;
            switch (operatior)
            {
                case "+":
                    result = calc.Add(x, y);
                    break;
                case "-":
                    result = calc.Sub(x, y);
                    break;
                case "/":
                    result = calc.Divide(x, y);
                    break;
                case "*":
                    result = calc.Mutiply(x, y);
                    break;
            }
            Console.WriteLine("The result is: "+result);
            Console.ReadLine();
            }
        }
    }
}
