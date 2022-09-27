using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WcfService1;

namespace WcfServiceHost1
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddr = new Uri("http://localhost:9003/BaseName");
            ServiceHost myHost = new ServiceHost(typeof(MyCalc), baseAddr);
            BasicHttpBinding myBinding = new BasicHttpBinding();
            ServiceEndpoint endpoint1 = myHost.AddServiceEndpoint(typeof(InterfaceCalc),myBinding,"endpoint1");
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            myHost.Description.Behaviors.Add(smb);
            try
            {
                myHost.Open();
                Console.WriteLine(" service started. ");
                Console.WriteLine(" press enter to stop service ");
                Console.ReadLine();
                myHost.Close();
            }
            catch (CommunicationException ce) {
                Console.WriteLine(" some exeception " + ce.Message);
                myHost.Abort();
            }
        }
    }
}
