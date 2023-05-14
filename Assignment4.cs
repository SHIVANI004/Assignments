using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a program that creates an array and displays the contents of the array. The array should be created dynamically. 
/// It means that the size, type should be set by the user of the Program. Take inputs for the values also. 
/// Finally it should display the values of the array.
/// </summary>
namespace Shivani_Assignments
{
    class Assignment4
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the size of array!");

            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter the values");
            for(int i=0;i<size;i++)
            {
                Console.WriteLine("Value for element {0}", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Display Array");
            for(int i=0;i<size;i++)
            {
                Console.WriteLine("{0}", arr[i]);
            }

        }
    }
}
