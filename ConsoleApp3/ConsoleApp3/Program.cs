using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApp3
{
    class Method
    {
        int[] x = new int[10];
        public Method()
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = 0;

            }
        }
        public int this[int a]
        {
            get { return x[a]; }
            set { x[a] = value; }

        }
        public void ASort()
        {
            Array.Sort(x);
            x.Max();

            for (int i = 0; i < x.Length; i++)
            {

                Console.WriteLine(x[i]);

            }
        }
 
    }
    class Program
    {
        public delegate void Tra();
        static void Main(string[] args)
        {
            Method w = new Method();
            Tra T = w.ASort;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("-------Input Next-----");
                w[i] = Convert.ToInt32(Console.ReadLine());
            }
            T.Invoke();
            Type t = w.GetType();
            MethodInfo[] Methods = t.GetMethods();
            foreach (MethodInfo m in Methods)
            {
                Console.WriteLine(m.ReturnType.Name + "" + m.Name);
            }
            Console.Read();
        }
        
    }
}
