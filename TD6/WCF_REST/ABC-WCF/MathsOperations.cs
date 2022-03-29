using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathsLibrary
{
    public class MathsOperations : IMathsOperations
    {
        public int Add(int a, int b) {
            return a + b;
        }

        public double Divide(int a, int b) {
            return a / (double) b;
        }

        public int Multiply(int a, int b) {
            return a * b;
        }

        public int Substract(int a, int b) {
            return a - b;
        }

        public int AddPost(int a, int b)
        {
            return a + b;
        }

        public int SubstractPost(int a, int b)
        {
            return a - b;
        }

        public int MultiplyPost(int a, int b)
        {
            return a * b;
        }

        public double DividePost(int a, int b)
        {
            return a / (double) b;
        }
    }
}
