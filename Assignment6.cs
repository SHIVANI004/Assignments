using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shivani_Assignments
{
    class Assignment6
    {
        static void Main(string[] args)
        {
            bool valid1 = isValidDate(2018, 13, 1);
            bool valid2 = isValidDate(2018, 2, 29);
            bool valid3 = isValidDate(2016, 2, 29);
            bool valid4 = isValidDate(2023, 8, 30);
            bool valid5 = isValidDate(2018, 2, 29);

            Console.WriteLine(valid1);
            Console.WriteLine(valid2);
            Console.WriteLine(valid3);
            Console.WriteLine(valid4);
            Console.WriteLine(valid5);


        }

        private static bool isValidDate(int year, int month, int day)
        {
            if(year<1 || year>9999)
            {
                return false;
            }
            if(month<1 || month>12)
            {
                return false;
            }
            if(day<1 || day>31)
            {
                return false;
            }
            if((month==4 || month==6 || month==9 || month==11) && day>30)
            {
                return false;
            }
            if(month==2)
            {
                bool isLeapYear = ((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0);
                if(isLeapYear && day>29)
                {
                    return false;
                }
                else if(!isLeapYear && day>28)
                {
                    return false;
                }
            }
            return true;
            
        }
    }
}
