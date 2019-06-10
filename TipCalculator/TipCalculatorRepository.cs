using System;
namespace TipCalculator
{
    public class TipCalculatorRepository
    {
        public decimal AddTipAmount (decimal billAmount, decimal tipAmount)
        {
            decimal totalBill = billAmount + tipAmount;
            return totalBill; 
        }

        public decimal FindCustomTipAmount (decimal billAmount, decimal tipPercentage)
        {
            decimal customTipAmount = billAmount * tipPercentage;
                return customTipAmount;
        }
    }
}
