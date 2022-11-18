using Newtonsoft.Json;
using System;
using System.Xml;


namespace Adaptor_Design_Pattern
{
    public class EmployeeAdapter : EmployeeManager, IEmployee
    {
        public override string GetAllEmployees()
        {
            string returnXml = base.GetAllEmployees();
            Console.WriteLine("Before Conversion : XML Format");
            Console.WriteLine(returnXml);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(returnXml);
            return JsonConvert.SerializeObject(doc, Newtonsoft.Json.Formatting.Indented);
        }
    }

}
