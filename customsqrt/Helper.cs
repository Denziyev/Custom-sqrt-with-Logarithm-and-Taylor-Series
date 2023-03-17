using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customsqrt
{
    public class Helper
    {
        public double Error(double TrueResult, double MyResult)
        {
            double eror = ((double)(TrueResult - (MyResult * MyResult)) / TrueResult)*100;
            return eror;
        }

        public double Exponent(double Base, int exponent)
        {
            double result = 1;
            for (int i = 1; i <= exponent; i++)
            {
                result *= Base;
            }
            return result;
        }

    }
}
