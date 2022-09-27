using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    //[ServiceContract(ProtectionLevel = System.Net.Security.ProtectionLevel.None)]
    //public interface ICalculator
    //{
    //    double Add(double n1, double n2);
    //    double Sub(double n1, double n2);
    //    double Multiply(double n1, double n2);
    //}

    [ServiceContract(ProtectionLevel = System.Net.Security.ProtectionLevel.None)]
    public interface InterfaceCalc
    {   [OperationContract]
        double Add(double n1, double n2);
        [OperationContract]
        double Sub(double n1, double n2);
        [OperationContract]
        double Multiply(double n1, double n2);
    }
}
