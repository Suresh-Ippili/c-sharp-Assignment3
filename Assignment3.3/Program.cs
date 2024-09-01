namespace Assignment3._3
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Input Customer IDNO: ");
            int customerId = int.Parse(Console.ReadLine());

            Console.Write("Input the name of the customer: ");
            string customerName = Console.ReadLine();

            Console.Write("Input the unit consumed by the customer: ");
            int units = int.Parse(Console.ReadLine());

            double amount = CalculateBill(units);
            double surcharge = (amount > 400) ? amount * 0.15 : 0;
            double netAmount = amount + surcharge;

            Console.WriteLine($"Customer IDNO: {customerId}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Unit Consumed: {units}");
            Console.WriteLine($"Amount Charges @Rs. {GetRatePerUnit(units)} per unit: {amount:F2}");
            Console.WriteLine($"Surcharge Amount: {surcharge:F2}");
            Console.WriteLine($"Net Amount Paid By the Customer: {Math.Max(netAmount, 100):F2}");
        }

        static double CalculateBill(int units)
        {
            double amount = 0;

            if (units <= 199)
            {
                amount = units * 1.20;
            }
            else if (units >= 200 && units < 400)
            {
                amount = units * 1.50;
            }
            else if (units >= 400 && units < 600)
            {
                amount = units * 1.80;
            }
            else if (units >= 600)
            {
                amount = units * 2.00;
            }

            return amount;
        }

        static double GetRatePerUnit(int units)
        {
            if (units <= 199)
            {
                return 1.20;
            }
            else if (units >= 200 && units < 400)
            {
                return 1.50;
            }
            else if (units >= 400 && units < 600)
            {
                return 1.80;
            }
            else
            {
                return 2.00;
            }
        }
    }
}
