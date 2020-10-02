using EmployeeWage;
using System;
using System.Collections.Generic;

namespace Employee_Wage_calc_Problem
{
    class Program
    {



        static void Main(string[] args)
        {
             //public Dictionary<String, double> totalWages = new Dictionary<String, double>();

          
            EmpWageBuilder ew1 = new EmpWageBuilder("Apple", 150, 20, 100);

            ew1.CalculateWage();

            Console.Out.WriteLine("\n**************************************\n");

            EmpWageBuilder ew2 = new EmpWageBuilder("Google", 125, 22, 125);

            ew2.CalculateWage();
        }
            

     }

        
}

