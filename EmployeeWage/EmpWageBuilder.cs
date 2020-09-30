using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class EmpWageBuilder : IEmpWageCal
    {
        List<Company> companyList;
        Dictionary<string, Double> companySalary;
        public void addCompanyWage(String company, Double empRatePerHour, Double numOfWorkingDays, Double workingHrs)
        {
            Company companyObject = new Company(company, empRatePerHour, numOfWorkingDays, workingHrs);
            companyList = new List<Company>();
            companyList.Add(companyObject);
            companySalary = new Dictionary<string, double>();
            companySalary[company] = empRatePerHour * numOfWorkingDays * workingHrs;
        }

        public Double getTotalWage(string company)
        {
            return companySalary[company];
        }
    }
}