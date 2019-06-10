using System;

namespace TipCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the easy to use Tip Calculator. Press any key to continue.");
            Console.ReadKey();
            Console.Clear();

            bool continueRunning = true;
            while (continueRunning)
            {
                Console.WriteLine("What would you like to do?\n" +
                "1. Find Tip Amount\n" +
                "2. Exit the Program");
                string response = Console.ReadLine();
                int input = int.Parse(response);

                switch (input)
                {
                    case 1:
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

                        decimal twentyThreePercent = parsedBillAmount * .23m;
                        decimal totalBillWithTwentyThree = parsedBillAmount + twentyThreePercent;
                        Console.WriteLine("23%:" + " " + twentyThreePercent.ToString("C") + " " + "& your bill total would be" + " " + totalBillWithTwentyThree.ToString("C"));

                        decimal twentyFivePercent = parsedBillAmount * .25m;
                        decimal totalBillWithTwentyFive = parsedBillAmount + twentyFivePercent;
                        Console.WriteLine("25%:" + " " + twentyFivePercent.ToString("C") + " " + "& your bill total would be" + " " + totalBillWithTwentyFive.ToString("C"));
                        Console.WriteLine("Press any key to return to the menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        continueRunning = false;
                        break;
                }
            }

            Console.Clear();
            Console.WriteLine("Thanks for using this program. Goodbye.");
            Console.ReadKey();
        }
    }
}
