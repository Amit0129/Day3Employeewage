using System.Security.Cryptography.X509Certificates;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject dMart=new EmpWageBuilderObject("Dmart", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.ToString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.ToString());
        }
    }
}