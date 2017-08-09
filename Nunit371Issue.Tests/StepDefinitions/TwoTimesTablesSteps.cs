using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Nunit371Issue.Tests.StepDefinitions
{
    [Binding]
    public class TwoTimesTablesSteps
    {
		Mathy sut;
		int result;

		[Given(@"I have a mathy instance")]
		public void GivenIHaveAMathyInstance()
		{
			sut = new Mathy();
		}

		[When(@"I multiply the numbers '(.*)' and '(.*)'")]
        public void WhenIMultiplyTheNumbersAnd(int p0, int p1)
        {
			result = sut.Multiply(p0, p1);
        }

		[Then(@"The result is valid '(.*)'")]
		public void ThenTheResultIsValid(int calculated)
        {
			Assert.That(this.result, Is.EqualTo(calculated));
        }
    }
}
