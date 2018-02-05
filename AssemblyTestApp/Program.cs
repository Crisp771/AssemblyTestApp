using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssemblyB;

namespace AssemblyTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new AssemblyBClass();
            Console.WriteLine(b.TestB());
            Console.ReadLine();
        }
    }
}
