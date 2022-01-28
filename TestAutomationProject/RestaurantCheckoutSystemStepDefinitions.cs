using NUnit.Framework;
using System;
using TechTalk.SpecFlow;


namespace TestAutomationProject
{
    [Binding]
    public class RestaurantCheckoutSystemStepDefinitions
    {
        [Given(@"A group of (.*) people orders (.*) starters, (.*) mains and (.*) drinks")]
        public void GivenAGroupOfPeopleOrdersStartersMainsAndDrinks(int people, int starterQty, int mainsQty, int drinksQty)
        {
            int time = 0;
            double expectedResult = ReusablePrograms.calculatebill(starterQty, mainsQty, drinksQty, time);
            ScenarioContext.Current.Add("Result", expectedResult);

            throw new PendingStepException();
        }

        [When(@"the order is sent to the endpoint")]
        public void WhenTheOrderIsSentToTheEndpoint()
        {
            //connect to dev end point
            //store the result as actualResult
            double actualresult=0;
            ScenarioContext.Current.Add("ActalResult", actualresult);
         
        }

        [Then(@"the total is calculated correctly in the bill")]
        public void ThenTheTotalIsCalculatedCorrectlyInTheBill()
        {
            double expectedresult = ScenarioContext.Current.Get<double>("Result");
            double actualResult = ScenarioContext.Current.Get<double>("ActalResult");
            Assert.AreEqual(expectedresult,actualResult);
            
         
        }

        [Given(@"A group of (.*) people order (.*) starter and (.*) mains and (.*) drinks before (.*)")]
        public void GivenAGroupOfPeopleOrderStarterAndMainsAndDrinksBefore(int people, int starterQty, int mainsQty, int drinksQty, int time)
        {
            double expectedResult = ReusablePrograms.calculatebill(starterQty, mainsQty, drinksQty, time);
            ScenarioContext.Current.Add("Result", expectedResult);
           
        }

        [When(@"(.*) more people at (.*) who order (.*) mains and (.*) drinks")]
        public void WhenMorePeopleAtWhoOrderMainsAndDrinks(int people, int time, int mainsQty, int drinksQty)
        {
            int starterQty = 0;
            double total;
            double result = ScenarioContext.Current.Get<double>("Result");
            double expectedResult = ReusablePrograms.calculatebill(starterQty, mainsQty, drinksQty, time); 
            total = expectedResult+ result;
            ScenarioContext.Current.Add("RebilledTotal", total);
       
        }

        [When(@"the updated order is sent to the endpoint")]
        public void WhenTheUpdatedOrderIsSentToTheEndpoint()
        {
            double actualresult = 0;
            ScenarioContext.Current.Add("ActalResult", actualresult);
        }

        [Then(@"the total is calculated correctly in the bill\.")]
        public void ThenTheTotalIsCalculatedCorrectlyInTheBill_()
        {
            double expectedresult = ScenarioContext.Current.Get<double>("Result");
            double actualResult = ScenarioContext.Current.Get<double>("ActalResult");
            Assert.AreEqual(expectedresult, actualResult);
        }
    }
}
