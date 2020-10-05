namespace HoneywellPOC.Controllers
{
    public partial class InterestController
    {
        public class SimpleInterestParameters
        {
            public SimpleInterestParameters()
            {
                denominator = 100;
            }
            public double principleAmount { get; set; }
            public double year { get; set; }
            public double rate { get; set; }
            public int denominator { get; }
            
        }
    }
}
