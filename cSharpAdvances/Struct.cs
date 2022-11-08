using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAdvances
{
    internal class Struct
    {
        int a;
        void run()
        {
            RealStruct rs;
            RealStruct[] str=new RealStruct[100];
            rs.a = 123;
        }
    }
    struct RealStruct
    {
       public int a;
       public int b;
        int c;
        public int run()
        {
            return 12;
        }
    }
}
