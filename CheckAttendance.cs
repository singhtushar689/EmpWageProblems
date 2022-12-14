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
            Random random= new Random();
            int empcheck = random.Next(2);
            if(empcheck == 1)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
