using HoneywellPOC.Models;
using TechTalk.SpecFlow;
using Xunit;

namespace poc_bdd.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        public CalculatorStepDefinitions(Maths maths)
        {
            _maths = maths;
        }
        private Maths _maths;
        private int _num1;
        private int _num2;
        private double _result;



        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {           
            _num1 = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {          
            _num2 = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _maths.Add(_num1, _num2);
        }

        [When(@"the two numbers are substracted")]
        public void WhenTheTwoNumbersAreSubstracted()
        {
            _result = _maths.Substract(_num1, _num2);
        }

        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = _maths.Multiply(_num1, _num2);
        }

        [When(@"the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            _result = _maths.Divide(_num1, _num2);
        }

        [When(@"the denomiator is (.*)")]
        public void WhenTheDenomiatorIs(int p0)
        {
            _result = _maths.Divide(_num1, _num2);
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {            
            Assert.Equal(result, _result);
        }
    }
}
