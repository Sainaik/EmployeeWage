using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class Company
    {
        String company;
        Double empRatePerHour;
        Double numOfWorkingDays;
        Double workingHrs;
        Double salary;
        public Company(String company, Double empRatePerHour, Double numOfWorkingDays, Double workingHrs)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.workingHrs = workingHrs;
        }
        public void setSalary(Double salary)
        {
            this.salary = salary;
        }

        public double getSalary()
        {
            return this.salary;
        }
    }
}