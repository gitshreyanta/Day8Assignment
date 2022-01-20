using System;
using System.Collections.Generic;
using System.Text;

namespace Day8
{
    public class Working_hrs
    {
        const int FULL_TIME = 2;
        const int PART_TIME = 1;
        const int EMP_RATE_PER_HOUR = 20;
        const int NUM_OF_WORKING_DAYS = 2;
        const int MAX_HRS_IN_MONTH = 10;
      
        public static int computeEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;


            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int randomInput = random.Next(0, 3);
                
                totalEmpHrs += empHrs;
                Console.WriteLine("Day3:" + totalWorkingDays + "Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
            return totalEmpWage;
        }





        static void Main(string[] args)
        {
            computeEmpWage();
        }

    }
}
