using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class ind
    {
        string[,] telephone = {{"10203","Vinit"},{"10204","Va"}};
        public string this [int no]
        {
            get {
                for (int i = 0; i < 2; i++)
                {
                    int tno = Convert.ToInt32(telephone[i, 0]);
                    if (no == tno)
                    {
                        return telephone[i, 1];
                    }
                    else
                    {
                        return "Doesnt Exist";
                    }
                }
                return "Doesnt Exist";
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ind x = new ind();
            int telno;
            string name;
            Console.WriteLine("Enter Teleno.");
            telno = Convert.ToInt32(Console.ReadLine());
            name = x[telno];
            Console.WriteLine("Name is {0}", name);

            Console.Read();
        }
    }
}
