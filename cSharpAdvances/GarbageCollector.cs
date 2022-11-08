using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAdvances
{
    internal class GarbageCollector
    {
        //memory allocation
        //free memory
        public Stack<Car> cars=new Stack<Car>();
        public event Action EventHandler;
        public void Run()
        {
            for (int i = 0; i < 10000; i++)
            {
                Car c = new Car();
                cars.Push(new Car());
            }
            //free the memory procces
            GC.Collect();

            //memory leaks
            for (int i = 0; i < 10; i++)
            {
            Screen s = new Screen();
            EventHandler += s.Run;
            }

        }
    }
    public class CarPool
    {
        private Stack<Car> cars=new Stack<Car>();
        public CarPool()
        {
            for (int i = 0; i < 100; i++)
            {
                cars.Push(new Car());
            }
        }
        public Car Alloctte()
        {
            return null;
        }
        public void Free(Car c)
        {

        }
    }
    public class Screen
    {
        public void Run()
        {

        }
    }
}
