using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace poc_bdd.Steps
{
    [Binding]
    public sealed class TemperatureByCitySteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public TemperatureByCitySteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"the city name as ""(.*)""")]
        public void GivenTheCityNameAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"a POST request to /api/Weather/temperatureByCity\?city=\{city}")]
        public void WhenAPOSTRequestToApiWeatherTemperatureByCityCityCity()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the response StatusCode should be (.*)")]
        public void ThenTheResponseStatusCodeShouldBe(int p0)
        {
            ScenarioContext.Current.Pending();
        }


    }
}
