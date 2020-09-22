using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoneywellPOC.Business
{
    public interface ISimpleInterest
    {
       dynamic CalculateInterest(double _princamt, double _rate, double _year, int denominator);


    }
}
