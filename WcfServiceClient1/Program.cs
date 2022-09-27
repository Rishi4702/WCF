using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfService1;

using WcfServiceClient1.ServiceReference2;

namespace WcfServiceClient1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" The client is started ");
           // part1
            Uri baseAddress;
            BasicHttpBinding mybind = new BasicHttpBinding();
            baseAddress = new Uri("http://localhost:9003/BaseName/endpoint1");
            EndpointAddress endpointAddress = new EndpointAddress(baseAddress);
            ChannelFactory<InterfaceCalc> myCf = new ChannelFactory<InterfaceCalc>(mybind, endpointAddress);
            InterfaceCalc myClient = myCf.CreateChannel();
            double res = myClient.Add(-2.0, 23.0);
            double res1 = myClient.Sub(3.0, 4.6);
            double rees = myClient.Multiply(2.0, 2.5);
            Console.WriteLine("Result of add :" + res + " Result of sub " + res1 + " Result of Multiply " + rees);
            Console.ReadLine();
            ((IClientChannel)myClient).Close();

            //part 2
            MyCalc myClient1 = new MyCalc();
            Console.WriteLine("Checcky");
            double pres = myClient1.Add(-2.0, 23.0);
            double pres1 = myClient1.Sub(3.0, 4.6);
            double prees = myClient1.Multiply(2.0, 2.5);
            Console.WriteLine("Result of add :" + pres + " Result of sub " + pres1 + " Result of Multiply " + prees);
            Console.ReadLine();
            Console.WriteLine("Closing the clinet");
        }
    }
}
