using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class EmpWageBuilderObject
    {
        public const int partTime = 1;
        public const int fullTime = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkDay;
        private int maxHourInMonth;
        private int totalEmpWage;


        public EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkDay, int maxHourInMonth)
        {

            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkDay = numOfWorkDay;
            this.maxHourInMonth = maxHourInMonth;

        }
        public void computeEmpWage()
        {


            int empHrs = 0, totalEmpHrs = 0, totalWorkDay = 0;

            while (totalEmpHrs <= this.maxHourInMonth && totalWorkDay < this.numOfWorkDay)
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
            int totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("Total Employ Wage for company " + company + " is " + totalEmpWage);

        }
        public string toString()
        {
            return "Total emp Wage for company : " + this.company + " is " + this.totalEmpWage;
        }
    }
}
