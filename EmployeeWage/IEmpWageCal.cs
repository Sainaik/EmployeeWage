using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    interface IEmpWageCal
    {
        Company AddCompany(String company, Double empRatePerHour, int numOfWorkingDays, int workingHrs);

        // Double getTotalWage(string company);

    }
}
