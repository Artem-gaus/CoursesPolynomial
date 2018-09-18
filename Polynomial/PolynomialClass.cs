using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial
{
    class PolynomialClass
    {
        protected int Degree {get; set;}
        protected int[] Сoefficients;
        public PolynomialClass(int degree, int[] coefficients)
        {
            this.Degree = degree;
            this.Сoefficients = new int[coefficients.Length];
            foreach (int i in coefficients)
            {
                this.Сoefficients[i] = coefficients[i];
            }
        }
    }
}
