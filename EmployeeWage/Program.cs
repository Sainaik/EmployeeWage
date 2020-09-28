using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            int is_full_time = 1;
            int is_part_time = 2;
            int wage = 20;

            //variable
            int type = rand.Next(0, 3);
            int hours = 0;
            int total_wage = 0;
            String empType = "";

            if (is_full_time == type)
            {
                hours = 8;
                empType = "Full_Time";

            }
            else if (is_part_time == type)
            {
                hours = 4;
                empType = "Part_Time";
            }
            else
            {
                hours = 0;
                empType = "No";
            }

            total_wage = hours * wage;

            Console.Out.WriteLine(empType + " employee wage: " + total_wage);

        }
    }
}
