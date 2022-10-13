using System.Security.Cryptography.X509Certificates;

namespace Employee
{
    internal class Program
    {
        public const int fullTime = 1;
        public const int partTime = 2;
        public const int empRatePerHour = 20;
        public const int numOfWorkDay = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("Employ Wage Calculation");

            int empHrs = 0, empWage = 0, totalEmpWage = 0;

            for(int day = 0; day < numOfWorkDay; day++)
            {
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
                empWage = empHrs * empRatePerHour;
                totalEmpWage += empWage;
            }
            Console.WriteLine("Total Employ Wage is : " + totalEmpWage);
        }
    }
}