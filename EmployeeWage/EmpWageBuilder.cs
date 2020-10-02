using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{

    class EmpWageBuilder : IEmpWageCal
    {
        //constants
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;

        List<Company> listOfCompnies = new List<Company>();

        public EmpWageBuilder()
        {

        }

        public Company AddCompany(String compName, double wagePerHour, int totalWorkingDays, int totalWorkHours)
        {
            Company company = new Company(compName, wagePerHour, totalWorkingDays, totalWorkHours);
            listOfCompnies.Add(company);
            return company;
        }


        public void CalculateWage(Company company)
        {
            Random rand = new Random();

            //variables

            int numberOfHours = 0;
            int workingDays = 1;
            double totalWage = 0;


            // run till the number of hours or workingdays reached in respective company

            while (numberOfHours <= company.TotalWorkingHours && workingDays <= company.TotalWorkingDays)
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

                Console.Out.WriteLine(company.CompName + " Day " + workingDays + " hours " + hours);

                workingDays++;
            }



            totalWage = numberOfHours * company.WagePerHour;

            Console.Out.WriteLine("\nTotal Wage for the month is: " + totalWage);

            company.MonthlyTotalWage = totalWage;
        }

    }
}
