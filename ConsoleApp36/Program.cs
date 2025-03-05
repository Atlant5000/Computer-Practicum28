using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] omas = { -2, 5, -6, 7, -6, 12, 10, -9 };
        }
        public static void Elements (int[] omas)
        {
            int maxelement = omas[0];
            int maxindex = 0;
            int a = 0;
            for (int i = 0; i < omas.Length; i++)
            {
                if (maxelement < omas[i]) 
                { 
                    maxindex = i;
                }
            }
            a = omas[0];
            omas[0] = omas[maxindex];
            omas[maxindex] = a;
        }
    }
}
