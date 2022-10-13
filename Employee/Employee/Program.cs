namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employ Wage Calculation");


            int fullTime = 1;
            int empRatePerHour = 20;

            int empHrs = 0;
            int empWage = 0;


            Random random = new Random();
            int empCheck = random.Next(0, 2);


            if (empCheck == fullTime)
            {
                empHrs = 8;
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