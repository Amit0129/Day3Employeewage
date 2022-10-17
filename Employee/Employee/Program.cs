using System.Security.Cryptography.X509Certificates;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyWage("Dmart", 20, 2, 10);
            empWageBuilder.addCompanyWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
        }
    }
}