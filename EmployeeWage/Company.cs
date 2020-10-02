using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class Company
    {
        //getters and setters for the instance variables

        //to add daiky wage
        public List<Double> DailyWage = new List<double>();

        public String CompName { get; set; }
        public double WagePerHour { get; set; }
        public int TotalWorkingDays { get; set; }
        public int TotalWorkingHours { get; set; }

        public double MonthlyTotalWage { get; set; }


        //company constructor
        public Company(String compName, double wagePerHour, int totalWorkingDays, int totalWorkingHours)
        {
            this.CompName = compName;
            this.WagePerHour = wagePerHour;
            this.TotalWorkingDays = totalWorkingDays;
            this.TotalWorkingHours = totalWorkingHours;
            this.MonthlyTotalWage = 0;

            Console.WriteLine("\nCompany " + this.CompName + " Created\n");

        }
    }
}









