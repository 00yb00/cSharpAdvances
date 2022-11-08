using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAdvances
{
    class aaa { }
    class bbb { }
    class ccc:aaa { public void RunCCC() { } }
    internal class IsAs
    {

        public void Run()
        {
            aaa a=new aaa();
            bbb b=new bbb();
            ccc c=new ccc();
            Oprator(c);
        }
        public void Oprator(object o)
        {
           
            bool test = o is aaa;
            test=o is bbb;  
            test=o is ccc;
            test = o is object;
            test=o is System.IO.FileStream;


            if(o is ccc)
            {//one way
                ccc asc = o as ccc;
                asc.RunCCC();   
                //secound way
                (o as ccc).RunCCC();
            }
        }
    }
}
