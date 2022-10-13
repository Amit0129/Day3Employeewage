namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employ Wage Calculation");


            int fullTime = 1;
            int partTime = 2;
            int empRatePerHour = 20;

            int empHrs = 0;
            int empWage = 0;


            Random random = new Random();
            int empCheck = random.Next(0, 3);


            if (empCheck == fullTime)
            {
                empHrs = 8;
            }
            else if (empCheck == partTime)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * empRatePerHour;
            Console.WriteLine("Employ Wage is : " + empWage);
        }
    }
}