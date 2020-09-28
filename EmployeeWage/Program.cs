using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            int wage = 20;

            //variable
            int type = rand.Next(0, 3);
            int hours = 0;
            int total_wage = 0;
            String empType = "";

            switch (type)
            {
                case IS_FULL_TIME:
                    hours = 8;
                    empType = "Full_Time";
                    break;
                case IS_PART_TIME:
                    hours = 4;
                    empType = "Part_Time";
                    break;
                default:
                    hours = 0;
                    empType = "No";
                    break;
            }

            total_wage = hours * wage;

            Console.Out.WriteLine(empType + " employee wage: " + total_wage);

        }
    }
}
