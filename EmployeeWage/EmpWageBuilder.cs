using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{

    

    class EmpWageBuilder
    {
        //constants
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;

        // instance variable
        
        Company company;
        

        
        public EmpWageBuilder(String compName, int wagePerHour, int totalWorkingDays, int totalWork)
        {
            company = new Company(compName,wagePerHour,totalWorkingDays,totalWork);
        }


        public void CalculateWage()
        {
            Random rand = new Random();

            //variables

            int numberOfHours = 0;
            int workingDays = 1;
            int totalWage = 0;


            // run till the number of hours or workingdays reached in respective company

            while (numberOfHours <= this.company.TotalWorkingHours && workingDays <= this.company.TotalWorkingDays)
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

                Console.Out.WriteLine(this.company.CompName + " Day " + workingDays + " hours " + hours);

                workingDays++;
            }

            

            totalWage = numberOfHours * this.company.WagePerHour;

            Console.Out.WriteLine("\nTotal Wage for the month is: "+ totalWage);

            this.company.MonthlyTotalWage = totalWage;
        }

    }
}
