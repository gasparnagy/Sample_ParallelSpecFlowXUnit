using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Calculator.Specs
{
    [Binding]
    public class CalculatorSteps
    {
        private readonly ScenarioContext scenarioContext;

        public CalculatorSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void InitializeCalculator()
        {
            scenarioContext["calc"] = new Calculator();
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int operand)
        {
            ((Calculator)scenarioContext["calc"]).Enter(operand);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            ((Calculator)scenarioContext["calc"]).Add();
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            ((Calculator)scenarioContext["calc"]).Multiply();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.Equal(expectedResult, ((Calculator)scenarioContext["calc"]).Result);
        }
    }
}
