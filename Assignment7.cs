using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shivani_Assignments
{
    class Assignment7
    {
        static bool isPrimeNumber(int num)
        {
            if (num < 2 || (num > 2 && num % 2 == 0))
            {
                return false;
            }
            int sqrt = (int)Math.Sqrt(num);
            for (int i = 3; i <= sqrt; i += 2)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            bool isPrime = isPrimeNumber(num);
            Console.WriteLine("{0} is prime: {1}", num, isPrime);
        }
    }
}
