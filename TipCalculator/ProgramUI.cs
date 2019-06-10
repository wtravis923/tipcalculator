using System;
namespace TipCalculator
{
    public class ProgramUI
    {
        TipCalculatorRepository _calculatorRepo = new TipCalculatorRepository();

         public void Run()
        {
            Console.WriteLine("Hello and welcome to the easy to use Tip Calculator. Press any key to continue.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Please enter the amount of your bill.");
            string billAmountAsString = Console.ReadLine();
            decimal parsedBillAmount = decimal.Parse(billAmountAsString);

            decimal fifteenPercent = parsedBillAmount * .15m;
            decimal totalBillWithFifteen = parsedBillAmount + fifteenPercent;
            Console.WriteLine("15%:" + " " + fifteenPercent.ToString("C") + " " + "& your bill total would be" + " " + totalBillWithFifteen.ToString("C"));

            decimal eighteenPercent = parsedBillAmount * .18m;
            decimal totalBillWithEighteen = parsedBillAmount + eighteenPercent;
            Console.WriteLine("18%:" + " " + eighteenPercent.ToString("C") + " " + "& your bill total would be" + " " + totalBillWithEighteen.ToString("C"));

            decimal twentyPercent = parsedBillAmount * .2m;
            decimal totalBillWithTwenty = parsedBillAmount + twentyPercent; 
            Console.WriteLine("20%:" + " " + twentyPercent.ToString("C") + " " + "& your bill total would be" + " " + totalBillWithTwenty.ToString("C"));

            decimal twentyFivePercent = parsedBillAmount * .25m;
            decimal totalBillWithTwentyFive = parsedBillAmount + twentyFivePercent;
            Console.WriteLine("25%:" + " " + twentyFivePercent.ToString("C") + " " + "& your bill total would be" + " " + totalBillWithTwentyFive.ToString("C"));
        }
    }
}