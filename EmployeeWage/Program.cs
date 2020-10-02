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


        static void Main(string[] args)
        {

            //Constants

            const int ADDCompany = 1;
            //const int CALCWage = 2;

            EmpWageBuilder ew = new EmpWageBuilder();

            bool loop = true;

            while (loop)
            {
                Console.WriteLine("1. Add Company and Caluclate Wage\n2.Exit");
                int choose = Convert.ToInt32(Console.ReadLine());

                double empRatePerHour = 0;
                int workingHrs = 0;
                int numOfWorkingDays = 0;

                switch (choose)
                {

                    case ADDCompany:

                        Random random = new Random();
                        int empType = random.Next(1, 3);

                        switch (empType)
                        {
                            case IS_FULL_TIME:

                                empRatePerHour = 120;
                                workingHrs = 8;
                                numOfWorkingDays = 20;

                                Console.WriteLine("Full Time Employee Details in following companies");
                                break;

                            case IS_PART_TIME:

                                empRatePerHour = 120;
                                workingHrs = 100;
                                numOfWorkingDays = 20;
                                Console.WriteLine("Part Time Employee Details in following companies");
                                break;

                            default:
                                break;
                        }

                        Company company = ew.AddCompany("Apple", empRatePerHour, numOfWorkingDays, workingHrs);
                        ew.CalculateWage(company);

                        company = ew.AddCompany("Google", 100, 25, 150);
                        ew.CalculateWage(company);
                        break;

                    default:
                        loop = false;
                        break;
                }

                Console.Out.WriteLine("\n**************************************\n");

            }

        }
    }
}
