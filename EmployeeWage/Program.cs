using EmployeeWage;
using System;
using System.Collections.Generic;

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

            //variables

            int numberOfHours = 0;
            int workingDays = 1;
            int totalWage = 0;


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

            totalWage = numberOfHours * wage_per_hour;

            return totalWage;
        }
        static void Main(string[] args)
        {

            int total_wage = 0;

            Dictionary<Company, int> companies = new Dictionary<Company, int>();

            Company apple = new Company("Apple", 150, 20, 100);

            total_wage = CalculateWage(apple.comp_name, apple.wage_per_hour, apple.total_working_days, apple.total_working_hours);

            //apple.total_salary = total_wage;

            //Console.WriteLine(apple.comp_name + "'s Wage : " + apple.total_salary);

            companies.Add(apple, total_wage);

            Company google = new Company("Google", 125, 22, 125);

            total_wage = CalculateWage(google.comp_name, google.wage_per_hour, google.total_working_days, google.total_working_hours);

            //google.total_salary = total_wage;

            //Console.WriteLine(google.comp_name + "'s Wage : " + google.total_salary);

            companies.Add(google, total_wage);

            foreach (KeyValuePair<Company, int> comp in companies)
            {
                Console.WriteLine(comp.Key.comp_name + "'s Wage : " + comp.Value);
            }

        }
    }
}