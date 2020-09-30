using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    interface IEmpWageCal
    { 
       void addCompanyWage(String company, Double empRatePerHour, Double numOfWorkingDays, Double workingHrs);

       Double getTotalWage(string company);
        
    }
}

