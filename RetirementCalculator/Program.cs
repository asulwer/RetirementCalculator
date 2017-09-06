using System;

namespace RetirementCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //example input: 200,12700,18,15,5
            Console.WriteLine("Enter these 5 values: weeklyinvestment,currentsavings,annualpercentage,annualtaxes,maxyears");
            Console.WriteLine("Press any key to get started");
            Console.ReadKey();

            do
            {
                Console.Write("weeklyinvestment ");
                double dWeeklyInvestment = Convert.ToDouble(Console.ReadLine());

                Console.Write("currentsavings ");
                double dCurrentSavings = Convert.ToDouble(Console.ReadLine());

                Console.Write("annualpercentage ");
                double dAnnualPercentage = Convert.ToDouble(Console.ReadLine()) / 100; //divide by 100 to get actual percentage value as a decimal

                Console.Write("annualtaxes ");
                double dAnnualTaxes = Convert.ToDouble(Console.ReadLine()) / 100; //divide by 100 to get actual percentage value as a decimal

                Console.Write("maxyears ");
                uint uiMaxYears = Convert.ToUInt32(Console.ReadLine());

                double dFinal = ((dWeeklyInvestment * 52) + dCurrentSavings) + ((((dWeeklyInvestment * 52) + dCurrentSavings) * dAnnualPercentage) * (1 - dAnnualTaxes));

                uint iCount = 0;
                Console.WriteLine($"Year {iCount} = {dFinal}");

                do
                {
                    iCount++;
                    dFinal = ((dWeeklyInvestment * 52) + dFinal) + ((((dWeeklyInvestment * 52) + dFinal) * dAnnualPercentage) * (1 - dAnnualTaxes));

                    Console.WriteLine($"Year {iCount} = {dFinal}");
                } while (iCount < uiMaxYears);

                Console.WriteLine("q to quit or anything else to start over");
            } while (Console.ReadKey().KeyChar != 'q');

            Console.ReadKey();
        }        
    }
}
