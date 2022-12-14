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
            if(empcheck == 1)
            {
                Console.WriteLine(" Full-Time");
                empHour = 16;
            }
            else if (empcheck == 2)
            {
                Console.WriteLine(" Part-Time ");
                empHour = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHour = 0;
            }
            dailyEmp = empHour * wagePerHour;
            Console.WriteLine("Total Employee wage is " + dailyEmp);


        }
    }
}
