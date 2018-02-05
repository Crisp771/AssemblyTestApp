using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace AssemblyA
{
    public class AssemblyAClass
    {
        public  Matrix<double> TestA()
        {
            return Matrix<double>.Build.Dense(100, 100, (i, j) => i * 10 * j);
        }

        public string TestB()
        {
            return Matrix<double>.Build.Dense(100, 100, (i, j) => i * 10 * j).ToString();
        }
    }
}
