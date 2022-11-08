using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAdvances
{
    internal class Tuple
    {
        //tuple
        public void Run()
        {
            string fname;
            string lname;
            int age;

            (string fname, string lname, int age) var1;
            var1 = ("hila", "choen", 18);
        }
        //this function return tuple 
        public (string fname, string lname, int age) CreatePerson()
        {
            string fname = "aaa";
            string lname = "aaa";
            int age = 18;
            (string fname, string lname, int age) var2;
            var2.age = age;
            var2.fname = fname;
            var2.lname = lname;
            return var2;
        }

    }
}
