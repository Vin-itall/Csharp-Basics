using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ConsoleApp1
{
    [Serializable]
    public class methods
    {
        public int Square(int i)
        {
            return i * i;
        }
        public int Cuber(int i)
        {
            return i * i*i;
        }
        public double KuchNahi(int i,double c)
        {
            Console.WriteLine("Yess");
            return i * c;
          
        }
    }
    class Program
    {
        //public delegate int Transform(int x);
       // public delegate double Te(int t, double r);
        public static void Main(string[] args)
        {
            //  methods n = new methods();
            Object n = Activator.CreateInstance(typeof(ConsoleApp1.methods));
            Object n2 = Activator.CreateInstance(typeof(ConsoleApp1.methods));

            Console.WriteLine("Daalo Int");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Daalo D");
            double s = Convert.ToDouble(Console.ReadLine());
         
            /*  foreach(Transform S in T1.GetInvocationList())
              {
                  int w=S.Invoke(x);
                  Console.WriteLine(x);
              }*/

            Type t = n.GetType();
            MethodInfo[] Methods = t.GetMethods();
            foreach (MethodInfo m in Methods)
            {
                ParameterInfo [] ps=m.GetParameters();
                foreach (ParameterInfo d in ps)
                {
                    Console.WriteLine(d.Name);
                    Object[] F = { x, s };
                    if ((d.ParameterType.Name).Equals("Double"))
                     {
                       // m.Invoke(n, F);
                        FileStream fs = File.Create("Temp.dat");
                        BinaryFormatter ss = new BinaryFormatter();
                        ss.Serialize(fs,n);
                        fs.Close();
                     }
                    
                }
            }
            FileStream Fo = File.OpenRead("Temp.dat");
            BinaryFormatter Bin = new BinaryFormatter();
            n2=(methods)Bin.Deserialize(Fo);
            Type t2 = n2.GetType();
            MethodInfo[] Methods2 = t2.GetMethods();
            foreach (MethodInfo m in Methods2)
            {
                ParameterInfo[] ps = m.GetParameters();
                foreach (ParameterInfo d in ps)
                {
                    Console.WriteLine(d.Position);
                    Object[] F = { x, s };
                    if ((d.ParameterType.Name).Equals("Double"))
                    {
                       m.Invoke(n2, F);
                    }

                }
            }

            Console.ReadLine();
        }
      
    }
}
