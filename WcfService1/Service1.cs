using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MyCalc : InterfaceCalc
    {
       public double Add(double n1, double n2)
        {
            Console.WriteLine("Add method was called with parameters n1 :"+n1+" n2 : "+n2);
            return n1 + n2;
        }

       public  double Multiply(double n1, double n2)
        {
            Console.WriteLine("Multiply method was called with parameters n1 :" + n1 + " n2 : " + n2);
            return n1 * n2;
        }

       public double Sub(double n1, double n2)
        {
            Console.WriteLine("sub method was called with parameters n1 :" + n1 + " n2 : " + n2);
            return n1 - n2;
        }
    }
}
