using System;

namespace MistakesCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age (WARNING! Guys Younger than 18 y.o. have no roots for registration process)");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your name (less than 100 symbols)");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Salary");
            double salary = double.Parse(Console.ReadLine());

            try
            {
                Employee employee = new Employee(age, name, salary);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine($"Stack Trace:{ex.StackTrace}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine($"Stack Trace:{ex.StackTrace}");
            }
            finally
            {
                Console.WriteLine("Finally Process");
            }
            Console.WriteLine("AfterFinallyBlock");
            Console.ReadKey();
        }
    }
}
