using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAdvances
{
    public class MakeBigRequest:IDisposable
    {
        public void Dispose()
        {
            Release();
        }
        public void Operator()
        {
            //take huge memory
            //create temp db
        }
        public void Release()
        {
            //drop temp db
        }
    }
    internal class Idispose
    {
        public void Run()
        {
        MakeBigRequest mo= new MakeBigRequest();
            mo.Operator();
            mo.Release();
            mo.Dispose();
            //free the the resources automatic in the end
            using(MakeBigRequest m = new MakeBigRequest())
            {
                m.Operator();
            }

        }


    }
}
