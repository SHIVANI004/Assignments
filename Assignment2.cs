
///Write a function that takes an array of numbers and it should display the Odd and Even numbers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shivani_Assignments
{
    class Assignment2
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Console.WriteLine("enter the length");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            foreach (var m in array){
                if (m % 2 == 0)
                {
                    Console.WriteLine("{0} is an even number",m);
                }
            
            else {
                Console.WriteLine("{0} is an odd number",m);
            }
        }
    }
}
    }
