using System;

namespace Adaptor_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee emp = new EmployeeAdapter();
            string value = emp.GetAllEmployees();
            Console.WriteLine("\n After Conversion : Json Format");
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
