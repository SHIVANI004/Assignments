using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shivani_Assignments
{
    class Assignment8
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the interest rate (as a decimal): ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the term (in years): ");
            int term = Convert.ToInt32(Console.ReadLine());

            double interestAmount = CalculateInterest(principal, rate, term);

            Console.WriteLine(interestAmount);
            Console.ReadKey();
        }

        static double CalculateInterest(double principal, double rate, int term)
        {
            double interest = principal * rate * term;
            return interest;
        }
    }
}
