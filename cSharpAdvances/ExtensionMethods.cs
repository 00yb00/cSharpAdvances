using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAdvances
{
    
    public class Utilities
    {
        public static int DotsCounter(string str)
        {
            return str.Split('.').Count()-1;
        }
    }
   
    public static class ExtStringMethods
    {
        public static int DotsCounter(this string str)
        {
            return str.Split('.').Count() - 1;
        }
        public static bool HasMobily(this Car car)
        {
            if (car.GetPrice()> 90000)
            {
                return true;    
            }
            else
            {
                return false;
            }
        }
    }   
    internal class ExtensionMethods
    {
        public void Run()
        {
            string s = "hello ... world.";
            int a = s.DotsCounter();
            a = Utilities.DotsCounter(s);

            Car c = new Car();
            c.HasMobily();
        }

    }
   public class Car
    {
        public int GetPrice()
        {
            return 10000;
        }
    }
}
