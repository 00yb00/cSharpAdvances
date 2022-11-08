using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAdvances
{
    internal class Foreach
    {
        public void Run()
        {
            LinkedList<string> list = new LinkedList<string>();
            var a=list.ToArray();
            int[] arr=new int[10];
            int sum = 0;
            //
            foreach (int i in arr)
            {
                sum = sum + i;
            }
            //אתחול בדיקה וקידום
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
        }
        public void RunMyItems()
        {
            Items items= new Items();
            string allStr = "";
            foreach (var item in items)
            {
                allStr+=item.ToString();
            }
        }
    }
    public class Items:IEnumerable, IEnumerator
    {
        string[] list = { "ball", "shirt", "tv", "cd" };
        int idx = -1;
        //return the Current 
        public object Current {
        get { return list[idx]; }   
        }
        public IEnumerator GetEnumerator()
        {
            return this;
        } 
        //check if to move to the next
        public bool MoveNext()
        {
            if (idx < list.Length-1)
            {
                idx++;
                return true;
            }
            else
            {
                return false;   
            }
        }
        
        public void Reset()
        {
            idx = -1;
        }
    }
}
