using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Calculator.Specs
{
    [Binding]
    public class CalculatorSteps
    {
        [BeforeScenario]
        public void InitializeCalculator()
        {
            ScenarioContext.Current["calc"] = new Calculator();
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int operand)
        {
            ((Calculator)ScenarioContext.Current["calc"]).Enter(operand);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            ((Calculator)ScenarioContext.Current["calc"]).Add();
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            ((Calculator)ScenarioContext.Current["calc"]).Multiply();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.Equal(expectedResult, ((Calculator)ScenarioContext.Current["calc"]).Result);
        }
    }
}
