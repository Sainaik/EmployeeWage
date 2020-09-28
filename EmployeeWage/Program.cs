

using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Random rand = new Random();

                int is_attended = rand.Next(0, 2);

                int attended = 1;


                if (is_attended == attended)
                {
                    Console.Out.WriteLine("Employee is present");
                }
                else
                {
                    Console.Out.WriteLine("Employee is absent");
                }
           
        }
    }
}
