using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class EmpWageBuilder : IEmpWageCal
    {
        List<Company> companyList;
        Dictionary<string, Double> companySalary;
        Dictionary<string, Double> compDailyWage;
        public void addCompanyWage(String company, Double empRatePerHour, Double numOfWorkingDays, Double workingHrs)
        {
            Company companyObject = new Company(company, empRatePerHour, numOfWorkingDays, workingHrs);
            companyList = new List<Company>();
            companyList.Add(companyObject);

            companySalary = new Dictionary<string, double>();
            compDailyWage = new Dictionary<string, double>();

            compDailyWage[company] = empRatePerHour * workingHrs;
            companySalary[company] = empRatePerHour  * workingHrs * numOfWorkingDays;
        }

        public Double getTotalWage(string company)
        {
            return companySalary[company];
        }

        public Double getDailtWage(string company)
        {
            return compDailyWage[company];
        }
    }
}