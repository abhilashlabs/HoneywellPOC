using System;
using System.Collections.Generic;
using System.Text;
using HoneywellPOC.Business;
using HoneywellPOC.Models;

namespace HoneywellPOC
{
    public class SimpleInterest : ISimpleInterest
    {

        double tot_amt, _interest;
        public virtual dynamic CalculateInterest(double _princamt, double _rate, double _year, int denominator)
        {
            Maths m = new Maths();

            if (_princamt < 0 || _rate < 0 || _year < 0)
            {
                return "error";
            }

            try
            {
                _interest = m.Divide(m.Multiply(_princamt, m.Multiply(_rate, _year)), denominator);

                if (denominator == 0)
                {
                    tot_amt = 0;
                }
                else
                    tot_amt = _interest;
                    //tot_amt = m.Add(_princamt, _interest);
            }
            catch
            {
                tot_amt = 0;
            }



            return tot_amt;
        }
    }
}


//public dynamic calculateInterest(double _princamt, double _rate, double _year, int denominator)
//{
//    Maths m = new Maths();

//    if (_princamt < 0 || _rate < 0 || _year < 0)
//    {
//        return "error";
//    }

//    try
//    {
//        _interest = m.Divide(m.Multiply(_princamt, m.Multiply(_rate, _year)), denominator);
//        tot_amt = m.Add(_princamt, _interest);
//    }
//    catch
//    {
//        tot_amt = 0;
//    }



//    return tot_amt;
//}
