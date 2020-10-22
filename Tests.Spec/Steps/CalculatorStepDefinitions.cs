using NUnit.Framework;
using SpecflowDemo;
using System;
using System.Runtime.CompilerServices;
using TechTalk.SpecFlow;

namespace Tests.Spec.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {        
        private Calculator Calculator { get; }
        private decimal Num1 { get; set; }
        private decimal Num2 { get; set; }
        private decimal ActualResult { get; set; }
        private Exception ActualException { get; set; }
        private readonly ScenarioContext _scenarioContext;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {            
            _scenarioContext = scenarioContext;
            Calculator = new Calculator();
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(decimal number)
        {
            Num1 = number;                        
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(decimal number)
        {
            Num2 = number;            
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {            
            try
            {
                ActualResult = Calculator.Add(Num1, Num2);
            }
            catch (Exception exception)
            {
                ActualException = exception;
            }            
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(decimal expectedResult)
        {
            Assert.AreEqual(expectedResult, ActualResult);
        }

        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            ActualResult = Calculator.Subtract(Num1, Num2);
        }

        [Then(@"an exception with the message ""(.*)"" is thrown")]
        public void ThenAnExceptionWithTheMessageIsThrown(string expectedMessage)
        {
            Assert.IsNotNull(ActualException);
            Assert.IsInstanceOf<InvalidOperationException>(ActualException);
            Assert.AreEqual("Negative numbers not allowed", expectedMessage);
        }

    }
}
