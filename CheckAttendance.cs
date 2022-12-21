using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblems
{
     public class CheckAttendance
     {
        public const int IS_PRESENT = 1;
        public const int IS_ABSENT = 2;
        public const int MAX_WORKING_HOURS = 100;
        public const int MAX_DAYS = 20;
        public const int EMP_WAGE_PER_HOUR = 20;
        public static void Attendance()
        {   
            int empHour = 0;
            int dailyEmp = 0;
            int totalWage = 0;
            int totalEmpHours = 0;
            int totalWorkingDays = 0;
            
            while (totalEmpHours < MAX_WORKING_HOURS && totalWorkingDays < MAX_DAYS )
            {
                    totalWorkingDays++;
                    Random random = new Random();
                    int empCheck = random.Next(3);
                    switch (empCheck)
                    {
                    case IS_PRESENT:
                            empHour = 16;
                            break;
                    case IS_ABSENT:
                            empHour = 8;       
                            break;
                     default:
                            empHour = 0;
                            break;
                    }

                totalEmpHours += empHour;
                dailyEmp = EMP_WAGE_PER_HOUR * empHour;
                Console.WriteLine("The daily wage is {0}",dailyEmp);   
                totalWage += dailyEmp;
            }
            Console.WriteLine("Daily Employee wage is " + dailyEmp);
            Console.WriteLine("Total EmployeeWage is " + totalWage);
        }
        public static void ComputeEmpWage(string[] args)
        {
            Attendance();
        }
     }
}
