using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF_SOAP_CLIENT.ServiceReference1;

namespace WCF_SOAP_CLIENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathsOperationsClient client = new MathsOperationsClient();

            Console.WriteLine(client.Add(2, 2));
            Console.WriteLine(client.Substract(2, 2));
            Console.WriteLine(client.Multiply(2, 2));
            Console.WriteLine(client.Divide(2, 2));
            
        }
    }
}
