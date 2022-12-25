using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblems
{
    public class EmpWageBuildArray
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private int numOfCompany = 0;
        private CompEmpWage[] compEmpWageArray;
        public EmpWageBuildArray() 
        { 
            this.compEmpWageArray = new CompEmpWage[5];
        }
        public void addCompanyEmpWage(string company,int empRatePerHour, int numOfWorkingDays,int maxHoursPerMonth)
        {
            this.compEmpWageArray[this.numOfCompany] = new CompEmpWage(company,empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }
        public void computeEmpWage()
        {
            for(int i = 0; i < numOfCompany; i++)
            {
                compEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.compEmpWageArray[i]));
                Console.WriteLine(this.compEmpWageArray[i].ToString());
            }
           
        }
        private int computeEmpWage(CompEmpWage compEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while(totalEmpHrs <= compEmpWage.maxHoursPerMonth && totalWorkingDays < compEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(3);
                switch(empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                        default: 
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day #: " + totalWorkingDays + "Emp Hours" + empHrs);
            }
            return totalEmpHrs * compEmpWage.empRatePerHour;
        }
    }
}
