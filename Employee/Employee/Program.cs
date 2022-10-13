namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employ Wage Calculation");
            int fullTime = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == fullTime)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee id absent");
            }
        }
    }
}