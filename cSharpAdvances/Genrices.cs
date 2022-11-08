using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAdvances
{
    internal class Genrices
    {
        public void Run()
        {
            List<string> list = new List<string>();
            list.Add("123456789");

            List<int> list1 = new List<int>();
            list1.Add(1);
            var p = new Point(100, 200);
            string s = func<Point, string>(p, "This is point");

            myStruct myStruct;
            myStruct.a = 1;

            // public class Sample<T> where T: unmanaged
            // Sample<int> sample = new Sample<int>();

            b sampleB = b.Create();

            // public class Sample<T> where T: a
            //Sample<b> sample = new Sample<b>();
            //public class Sample<T> where T : a, new()
            Sample<a> sample = new Sample<a>();
            //Sample<c> sample2 = new Sample<c>();
            //Sample<a> sample3 = new Sample<a>();

            // public class Sample<T,Z> where T: IEnumerable<Z>
            //Sample<List<string>,string> sample = new Sample<List<string>, string>(); 

            // Sample<myStruct> sample = new Sample<myStruct>();
            //sample.SetItem(new Point(100, 100));
        }

        public class Point
        {
            int x;
            int y;
            public Point(int x,int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        // managed vv unmanaged
        public class Sample<T> where T : a
        {
            public void SetItem(T item)
            {

            }
        }

        struct myStruct
        {
            public int a;
            public int b;
            private int myVar;

            public int MyProperty
            {
                get { return myVar; }
                set { myVar = value; }
            }

            void Print()
            {
                Console.WriteLine("1111");
            }
        }


        public class PrintManager
        {

        }

        public string func<T, Z>(T o, Z y)
        {
            string s = o.ToString() + " " + y.ToString();
            return s;
        }

        public class a { }
        public class b : a
        {
            private b()
            {

            }

            public static b Create()
            {
                return new b();
            }


        }
        public class c : a { }
    }
    }
