using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customsqrt
{
    
    public class Sqrt : Helper
    {
        public double e = 2.71828;

        public double ssqqrrtt(double x)
        {
            double MyResult = (double)ln(x) / 2;
           
            double t = 1;
            do
            {
                t=t+0.1;

            } while (((ln(t) - MyResult) / ln(t)) * 100 >= 5);

            if(((ln(t) - MyResult) / ln(t)) * 100 <= 5)
            {
                do
                {
                    t = t + 0.01;
                } while (((ln(t) - MyResult) / ln(t)) * 100 <= 0.1);
            }


            

            return t;
        }



        
        

        public double ln(double x)
        {
            
            double pm = (double)(x - 1) / (x + 1);
            double MyResult = 0;           
            int r = 1;                                                                   //count
            int error=200;
            if (x > 90 && x < 280) error = 500;
            else if (x < 500) error = 1000;
            else if (x > 500) error = 1500;

            do
            {
                 MyResult += (2 * ((double)1 / r) * Exponent(pm, r));               
                 r = r + 2;

            } while (r<error);

           return MyResult;
        }
    }
}