using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoneywellPOC.Interfaces
{
    public interface IMaths
    {
        double Multiply(double a, double b);
        double Add(double a, double b);
        double Subtract(double a, double b);
        double Divide(double a, int b);
    }
}
