using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAdvances
{
    internal class Event
    {
        public delegate void TimeOutFunc(int time);
        public event TimeOutFunc TimeOutHandler;
        public void Run()
        {
            //send the message
            if(TimeOutHandler != null)  
            TimeOutHandler(1200);
        }
    }
    public class Operate
    {
            Event e1=new Event();   
            DB d1=new DB(); 
            UI u1=new UI();
        //regstaion to Event message
        public void Init()
        {
            e1.TimeOutHandler += d1.UpDateDBAfterTimeOut;
            e1.TimeOutHandler += u1.UpDateUIAfterTimeOut;

            e1.Run();
        }

    }
    //tables
    public class DB
    {
        public void UpDateDBAfterTimeOut(int time)
        {

        }
    }
    //view
    public class UI
    {
        public void UpDateUIAfterTimeOut(int time)
        {

        }
    }
}
