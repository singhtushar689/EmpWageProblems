using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblems
{
    internal class CheckAttendance
    {
        public static void Attendance()
        {
            int present = 1;
            int wagePerHour = 20;
            int maxDays = 20;
            int empHour = 0;
            int dailyEmp = 0;
            int totalWage = 0;
            
            for (int i = 1; i <= maxDays; i++)
            {
                Random random = new Random();
                int empcheck = random.Next(3);
                switch (empcheck)
                {
                    case 1:
                        empHour = 16;
                        Console.WriteLine("Full-Time");
                        break;
                    case 2:
                        empHour = 8;
                        Console.WriteLine("Part-Time");
                        break;
                    default :
                        empHour = 0;
                        Console.WriteLine("Employee is absent");
                        break;
                       
                }
                totalWage += dailyEmp;
                dailyEmp = wagePerHour * empHour;
                Console.WriteLine("Daily Employee wage is " + dailyEmp);
               

            }
            Console.WriteLine("Total EmployeeWage is " + totalWage);





        }
    }
}
