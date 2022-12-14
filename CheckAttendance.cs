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
            int empHour = 0;
            int dailyEmp = 0;
            Random random= new Random();
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
                case 3:
                    empHour = 0;
                    Console.WriteLine("Employee is absent");
                    break;
            }
            dailyEmp = empHour * wagePerHour;
            Console.WriteLine("Total Employee wage is " + dailyEmp);
        }
    }
}
