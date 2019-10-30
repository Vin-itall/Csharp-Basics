using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApp6
{
    class Test
    {
        int i;
        int j;
        public void sum(int c, int d)
        {
            Console.WriteLine(c + d);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {   
            
            Object obj=Activator.CreateInstance(typeof(ConsoleApp6.Test));
            MethodInfo mi = typeof(ConsoleApp6.Test).GetMethod("sum");
           Object[] P = { 1, 1 };
            mi.Invoke(obj, P);
            Console.ReadLine();
        }
    }
}
