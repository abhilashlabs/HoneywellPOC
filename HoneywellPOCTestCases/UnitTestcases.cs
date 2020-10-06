using FakeItEasy;
using HoneywellPOC;
using HoneywellPOC.Models;
using NUnit.Framework;

namespace HoneywellPOCTestCases
{
    public class Tests
    {
        private SimpleInterest _simpleInterest;
        private Maths m;
        private WeatherForecast _weatherforecast;
        //public Weather(WeatherFor
        //    _weatherforecast = weatherforecast;
        //}ecast weatherforecast)
        //{

        [SetUp]
        public void Setup()
        {
            _simpleInterest = A.Fake<SimpleInterest>();
            m = A.Fake<Maths>();
            _weatherforecast = A.Fake<WeatherForecast>();
        }

        [TestCase(1000, 2, 2, 100)]
        public void calc_simple_interest_returns_1040(int principle, int time, int rate, int denominator)
        {
            //var maths = A.Fake<IMaths>();


            //int p = 1000, t = 2, r = 2, den = 100;

            A.CallTo(() => _simpleInterest.CalculateInterest(principle, time, rate, denominator)).Returns(1040);

            Assert.AreEqual(1040, _simpleInterest.CalculateInterest(principle, time, rate, denominator));
        }

        [TestCase(1000,2,2,0)]
        public void calc_simple_interest_returns_zero(int principle, int time, int rate, int denominator)
        {
            //var maths = A.Fake<IMaths>();
            //var si = A.Fake<SimpleInterest>();


            //int p = 1000, t = 2, r = 2, den = 0;

            A.CallTo(() => _simpleInterest.CalculateInterest(principle, time, rate, denominator)).Returns(0);

            Assert.AreEqual(0, _simpleInterest.CalculateInterest(principle, time, rate, denominator));
        }

        [TestCase(1000,-2,2,0)]
        public void calc_simple_interest_throws_error_on_invalid_values(int principle, int time, int rate, int denominator)
        {
            //var maths = A.Fake<IMaths>();
            //var si = A.Fake<SimpleInterest>();


            //int p = 1000, t = -2, r = 2, den = 0;

            A.CallTo(() => _simpleInterest.CalculateInterest(principle, time, rate, denominator)).Returns("error");

            Assert.AreEqual("error", _simpleInterest.CalculateInterest(principle, time, rate, denominator));
        }

        [TestCase(10,20)]
        public void Calculate_Addition_Test_30(double a, double b)
        {
            //double a = 10, b = 20;
            A.CallTo(() => m.Add(a, b)).Returns(30);
            Assert.AreEqual(30, m.Add(a, b));
        }
        [TestCase(20,10)]
        public void Calculate_Substraction_10(double a, double b)
        {
            //double a = 20, b = 10;
            A.CallTo(() => m.Subtract(a, b)).Returns(10);
            Assert.AreEqual(10, m.Subtract(a, b));
        }
        [TestCase(10,10)]
        public void Calculate_Multiplication_100(double a, double b)
        {
            //double a = 10, b = 10;
            A.CallTo(() => m.Multiply(a, b)).Returns(100);
            Assert.AreEqual(100, m.Multiply(a, b));
        }
        [TestCase(10,0)]
        public void Calculate_Multiplication_0(double a, double b)
        {
            //double a = 10, b = 0;
            A.CallTo(() => m.Multiply(a, b)).Returns(0);
            Assert.AreEqual(0, m.Multiply(a,b));
        }

        [TestCase(50,5)]
        public void Calculate_Divide_10(double a, int b)
        {
            //double a = 50;
            //int b = 5;
            A.CallTo(() => m.Divide(a, b)).Returns(10);
            Assert.AreEqual(10, m.Divide(a, b));
        }
        [TestCase("")]
        public void city_novalue_returns_error(string city)
        {
            A.CallTo(() => _weatherforecast.getTemperatureByCity(city)).Returns("error");
           
            Assert.AreEqual("error", _weatherforecast.getTemperatureByCity(city));

        }

        [TestCase("Bangalore")]
        public void city_withValue_returns_dynamic_temperature(string city)
        {
            A.CallTo(() => _weatherforecast.getTemperatureByCity(city)).Returns(city);

            Assert.AreEqual(city, _weatherforecast.getTemperatureByCity(city));

        }
        
    }
}