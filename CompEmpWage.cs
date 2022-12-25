﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblems
{
    public class CompEmpWage
    {        
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;
        public CompEmpWage(string company,int empRatePerHour,int numOfWorkingDays,int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour= empRatePerHour;
            this.numOfWorkingDays= numOfWorkingDays;
            this.maxHoursPerMonth= maxHoursPerMonth;    

        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage= totalEmpWage;
        }
        public string toString()
        {
            return ("TotalEmpWage for the company : " + this.company + "is" + this.totalEmpWage);
        }    
    }
}
