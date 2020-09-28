using System;

namespace Employee_Wage_calc_Problem
{
    class Program
    {
        //constants

        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;

        public static int CalculateWage(String comp_name, int wage_per_hour, int total_working_days, int total_working_hours)
        {
            Random rand = new Random();

            //variable

            int numberOfHours = 0;
            int workingDays = 1;
            int total_wage = 0;

            // run till the number of hours or workingdays reached in respective company

            while (numberOfHours <= total_working_hours && workingDays <= total_working_days)
            {

                int type = rand.Next(0, 3);
                int hours = 0;

                // switch to type of Employee

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

                // add the hours to total hrs

                numberOfHours += hours;

                Console.Out.WriteLine(comp_name + " Day " + workingDays + " hours " + hours);

                workingDays++;

            }

            total_wage = numberOfHours * wage_per_hour;

            return total_wage;
        }
        static void Main(string[] args)
        {

            int total_wage = 0;

            total_wage = CalculateWage("Apple", 150, 20, 150);

            Console.Out.WriteLine("Apple's Total wage of the month  :" + total_wage);

            total_wage = CalculateWage("Google", 125, 22, 150);

            Console.Out.WriteLine("Google's Total wage of the month :" + total_wage);

        }
    }
}