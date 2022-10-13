using System.Security.Cryptography.X509Certificates;

namespace Employee
{
    internal class Program
    {
        public const int fullTime = 1;
        public const int partTime = 2;
        public const int empRatePerHour = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("Employ Wage Calculation");

            int empHrs = 0;
            int empWage = 0;


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
            Console.WriteLine("Employ Wage is : " + empWage);
        }
    }
}