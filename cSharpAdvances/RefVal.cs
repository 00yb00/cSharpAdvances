using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace cSharpAdvances
{
    internal class RefVal
    {
        public void run()
        {
            //stack
          Label l=
            //heap
          new Label();
            l.Text = "454";
            ChangeLable(l);
            int a = 100, b = 0;
            //not change beacuse its not on a adress
            Change(a);
            //change beacuse i send l adress
            Change(ref a, out b);
        }
        public int Change(int a)
        {
            a++;
            return a * a;
        }
        public void Change(ref int a,out int b)
        {
            a++;
            b = a * a;
        }
        public int ChangeLable(Label l)
        {
            string s="";
            
            s= "1234567890";
            l.Text = "123";
            return 10;

        }
        public void Val()
        {
            //system.ValueType vs Object
            int a;
           
            int? b;
            b= null;
            if(b==null)
            {

            }
            if(b is null)
            {

            }
             Label l = null;//not null
            if(l != null)
            {
                l = new Label();

            }
            b = 3;
            a = b ?? 2;
        }
    }
}
