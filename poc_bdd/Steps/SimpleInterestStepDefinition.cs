﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HoneywellPOC;
using TechTalk.SpecFlow;
using Xunit;

namespace poc_bdd.Steps
{
    [Binding]
    public sealed class SimpleInterestStepDefinition
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly SimpleInterest _simpleInterest;

        private int _principalAmount;
        private int _rate;
        private int _year;
        private dynamic _result;

        public SimpleInterestStepDefinition(SimpleInterest simpleInterest)
        {
            _simpleInterest = simpleInterest;
        }

        [Given(@"the principal amount is (.*)")]
        public void GivenThePrincipalAmountIs(int p0)
        {
            _principalAmount = p0;
        }

        [Given(@"the interest rate is (.*)")]
        public void GivenTheInterestRateIs(int p0)
        {
            _rate = p0;
        }

        [Given(@"the tenure is (.*)")]
        public void GivenTheTenureIs(int p0)
        {
            _year = p0;
        }

        [When(@"the calculation part is happened")]
        public void WhenTheCalculationPartIsHappened()
        {
            // in developer perspective
            _result = _simpleInterest.CalculateInterest(_principalAmount, _rate, _year, 100);

            // how a QA person will write
            //_result = (_principalAmount * _rate * _year)/100;
            //_result = 40;
        }

        [When(@"the calculation part is happened with denominator as (.*)")]
        public void WhenTheCalculationPartIsHappenedWithDenominatorAs(int p0)
        {            
            _result = _simpleInterest.CalculateInterest(_principalAmount, _rate, _year, 0);
        }

        [When(@"the calculation part is happened with rate as (.*)")]
        public void WhenTheCalculationPartIsHappenedWithRateAs(int p0)
        {
            _result = _simpleInterest.CalculateInterest(_principalAmount, _rate, _year, 100);
        }





        [Then(@"the simpleinterest should be (.*)")]
        public void ThenTheSimpleinterestShouldBe(int p0)
        {
            Assert.Equal(p0, _result);
        }

      

        [Then(@"the simple interest should be ""(.*)""")]
        public void ThenTheSimpleInterestShouldBe(string p0)
        {
            // this assert is for checking whether the formula is returning error or not
            Assert.Equal(p0, _result);
        }


    }
}
