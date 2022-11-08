using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAdvances
{
    internal class Type
    {
        FileStream fs = System.IO.File.OpenRead("aaa.txt");

        public void Run()
        {
            try { 
            for (int i = 0; i < 100; i++)
            {
                Type t = new Type();
            }}
            catch (Exception ex)
            { 

            }
            finally
            {
                fs.Close();
            }

        }
        //constractor
        public Type()
        {

        }
        //descactor
        ~Type()
        {
            fs.Close();
        }
    }
}
