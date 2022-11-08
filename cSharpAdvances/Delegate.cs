using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAdvances
{
    internal class Delegate
    {
        public delegate int CalcFunc(int a, int b);
        public void Run()
        {
            CalcFunc f;
            f = CalcMul;
            f(1, 3);
            f = CalcSub;
            f(3, 5);
            f = CalcAdd;
            f(2, 4);
        }
        public int CalcMul(int a, int b)
        {
            return a * b;
        }
        public int CalcAdd(int a, int b)
        {
            return a + b;
        }
        public int CalcSub(int a, int b)
        {
            return a - b;
        }
        public int CalcTax(int price, CalcFunc func)
        {
            return (func(price, 20));
        }
    }
}
