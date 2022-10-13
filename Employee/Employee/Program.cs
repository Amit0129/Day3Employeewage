using System.Security.Cryptography.X509Certificates;

namespace Employee
{
    internal class Program
    {
        public const int fullTime = 1;
        public const int partTime = 2;
        public const int empRatePerHour = 20;
        public const int numOfWorkDay = 20;
        public const int maxHourInMonth = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Employ Wage Calculation");

            int empHrs = 0, totalEmpHrs = 0, totalWorkDay = 0;

            while(totalEmpHrs <= maxHourInMonth && totalWorkDay < numOfWorkDay)
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
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine(totalEmpHrs);
            Console.WriteLine("Total Employ Wage is : " + totalEmpWage);
        }
    }
}