using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAdvances
{
    internal class Check
    {
        public void Run()
        {
            byte a = 1;
            int b = 2;
            checked { 
                a++;
                a++;
                a++;
            }
            unchecked
            {
                a++;
            }
            a = byte.MaxValue;
            a++;
            for (long i = 0; i < long.MaxValue; i++)
            {
                a++;
                b++;
            }
        }
    }
}
