using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationProject
{
    public class ReusablePrograms
    {

        public static double calculatebill(int starterQty, int mainsQty, int drinksQty, int time)
        {
            double starter = 4.00;
            double mains = 7.00;
            double drinks = 2.50;
            double totalstarter= starterQty*starter;
            double totalmains = mainsQty * mains;
            double totaldrinks= drinksQty* drinks;
            double result;
            if (time<19)
            {
                double discountedtotaldrinks = totaldrinks - (totaldrinks * 30 / 100);
                result = totalstarter + totalmains + discountedtotaldrinks;
                return result;
            }
            else 
            {
                result = totalstarter + totalmains + totaldrinks;
                return result;
            }


        }

    }
}
