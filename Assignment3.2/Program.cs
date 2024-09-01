namespace Assignment3._2
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Input the marks obtained in Physics: ");
            int phy = int.Parse(Console.ReadLine());

            Console.Write("Input the marks obtained in Chemistry: ");
            int chem = int.Parse(Console.ReadLine());

            Console.Write("Input the marks obtained in Mathematics: ");
            int math = int.Parse(Console.ReadLine());

            bool isEligible = IsEligibleForAdmission(math, phy, chem);

            if (isEligible)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
        }

        static bool IsEligibleForAdmission(int math, int phy, int chem)
        {
            int total = math + phy + chem;
            int mathPhyTotal = math + phy;

            return (math >= 65 && phy >= 55 && chem >= 50 && (total >= 180 || mathPhyTotal >= 140));
        }
    }
}
