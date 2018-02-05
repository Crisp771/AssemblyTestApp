using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssemblyA;

namespace AssemblyB
{
    public class AssemblyBClass
    {
        //  Doesn't work.   B doesn's know about the matrix type
        //public Matrix<double> TestTypeB()
        //{
        //    var a = new AssemblyAClass();
        //    return a.TestA();
        //}

        //  Doesn't work.   B doesn's know about the matrix type
        //public string TestBToString()
        //{
        //    var a = new AssemblyAClass();
        //    var x = a.TestA().ToString();
        //}

        public string TestB()
        {
            var a = new AssemblyAClass();
            var x = a.TestB();
            return x;
        }
    }
}
