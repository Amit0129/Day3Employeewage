using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class EmpWageBuilderArray
    {
        public const int partTime = 1;
        public const int fullTime = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWagesArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWagesArray = new CompanyEmpWage[5];
        }
        public void addCompanyWage(string company, int empRatePerHour, int numOfWorkDay, int maxHourInMonth)
        {
            companyEmpWagesArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkDay, maxHourInMonth);
            numOfCompany++;
        }
        public void computeEmpWage()
        {
            for (int i=0; i < numOfCompany; i++)
            {
                companyEmpWagesArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWagesArray[i]));
                Console.WriteLine(this.companyEmpWagesArray[i].ToString());
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkDay = 0;

            while (totalEmpHrs <= companyEmpWage.maxHourInMonth && totalWorkDay < companyEmpWage.numOfWorkDay)
            {
                totalWorkDay++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case fullTime:
                        empHrs = 8;
                        break;
                    case partTime:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day" + totalWorkDay + "Employee Hour" + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }

    }
}
