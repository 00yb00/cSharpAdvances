using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAdvances
{
    internal class Interface
    {

    }
    public interface ITax
    {
        double Maam(double price);
        double IncomminTax(double price);

    } 
    public class Eilat: ITax
    {
        public double Maam(double price)
        {
            return 0;
        }
        public double IncomminTax(double price)
        {
            return 0;
        }
    }
    public class regular : ITax
    {
        public double Maam(double price)
        {
            return price* 1.5;
        }
        public double IncomminTax(double price)
        {
            return price*1.17;
        }

    }
    public class InterfacesSamples
    {
        public void Run()
        {
            ITax[] arr=new ITax[10];    
            arr[0]=new Eilat();
            arr[1]=new regular();

            arr[0].Maam(10); 
            arr[1].IncomminTax(10);    
        }
    }
}
