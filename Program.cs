using System;
 
namespace DrillPayRate
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1:");
            Console.WriteLine("Please enter your hourly rate: ");
            string Per1HR = Console.ReadLine();
            Console.WriteLine("Please enter Hours Worked : ");
            string Per1HW = Console.ReadLine();

            Console.WriteLine("Person 2:");
            Console.WriteLine("Please enter hourly rate : ");
            string Per2HR = Console.ReadLine();
            Console.WriteLine("Please enter Hours Worked per week : ");
            string Per2HW = Console.ReadLine();

            double P1Ann = ((Convert.ToDouble(Per1HR) * Convert.ToDouble(Per1HW)) * 52);
            double P2Ann = ((Convert.ToDouble(Per2HR) * Convert.ToDouble(Per2HW)) * 52);

            Console.WriteLine("Annual Salary for Person 1 : ");
            Console.WriteLine("$" + P1Ann);
            //Console.ReadLine();

            Console.WriteLine("Annual Salary for Person 2 : ");
            Console.WriteLine("$" + P2Ann);

            Console.WriteLine("Does Person 1 make more than Person 2 ?  ");
            bool TrueFalse = Convert.ToInt32(P1Ann) > Convert.ToInt32(P2Ann);
            Console.WriteLine(TrueFalse);
            Console.ReadLine();
        }
    }
}
