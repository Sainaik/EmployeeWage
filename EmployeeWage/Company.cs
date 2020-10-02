using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class Company
    {
        //getters and setters for the instance variables

        public String CompName { get; set; }
        public int WagePerHour { get; set; }
        public int TotalWorkingDays { get; set; }
        public int TotalWorkingHours { get; set; }

        public int MonthlyTotalWage { get; set; }


        //company constructor
        public Company(String compName, int wagePerHour, int totalWorkingDays, int totalWorkingHours)
        {
            this.CompName = compName;
            this.WagePerHour = wagePerHour;
            this.TotalWorkingDays = totalWorkingDays;
            this.TotalWorkingHours = totalWorkingHours;
            this.MonthlyTotalWage = 0;

        }
    }
}
