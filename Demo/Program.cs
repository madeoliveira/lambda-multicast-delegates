using Course.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    delegate void BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 234;
            double b = 432;
            BinaryNumericOperation op = CalculationService.ShowMax;
            op += CalculationService.ShowSum;

            op.Invoke(a, b);

        }
    }
}
