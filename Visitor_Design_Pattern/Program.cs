using System;

namespace Visitor_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient patient = new Patient("Akash");
            Physician physician = new Physician();
            Dentist dentist = new Dentist();
            Nurse nurse = new Nurse();
            Family family = new Family();

            IVisitor[] visitors = {physician, dentist, nurse, family};
            foreach (IVisitor visitor in visitors)
            {
                patient.Attend(visitor);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
