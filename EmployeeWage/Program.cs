using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            //constants

            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int TOTAL_WORKING_HOURS = 100;
            const int TOTAL_WORKING_DAYS = 20;
            const int WAGE_PER_HOUR = 20;

            //variable

            int numberOfHours = 0;
            int workingDays = 0;
            int total_wage = 0;

            while (numberOfHours <= TOTAL_WORKING_HOURS && workingDays <= TOTAL_WORKING_DAYS)
            {
                int type = rand.Next(0, 3);
                int hours = 0;
                switch (type)
                {
                    case IS_FULL_TIME:
                        hours = 8;
                        break;
                    case IS_PART_TIME:
                        hours = 4;
                        break;
                    default:
                        hours = 0;
                        break;

                }

                numberOfHours += hours;
               
                Console.Out.WriteLine("Day " + workingDays + " hours " + hours);

                workingDays++;
            }

            total_wage = numberOfHours * WAGE_PER_HOUR;

            Console.Out.WriteLine("Total wage of the month :" + total_wage);

        }
    }
}
