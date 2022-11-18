using System;

namespace Visitor_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //The Visitor pattern suggests that you place the new behavior into a separate class called visitor,
            //instead of trying to integrate it into existing classes. The original object that had to perform
            //the behavior is now passed to one of the visitor’s methods as an argument, providing the method access
            //to all necessary data contained within the object.

            Patient patient = new Patient("Akash");
            Physician physician = new Physician();
            Dentist dentist = new Dentist();
            Nurse nurse = new Nurse();
            Family family = new Family();

            IVisitor[] visitors = {physician, dentist, nurse, family};
            foreach (IVisitor visitor in visitors)
            {
                patient.Accept(visitor);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
