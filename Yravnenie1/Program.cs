using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yravnenie1
{
    class Program
    {
        static void Main(string[] args)
        {
            double min = 0, max = 10;
            const double toch = 0.0001;
            double maxst = 1000;
            double sr = 0;
            int count = 0;
            while (max - min > toch && count < maxst)
            {
                sr = (min + max) / 2;
                double Fsr = F(sr);
                double Fa = F(min);
                double Fb = F(max);
                if ((Fa * Fsr) <= 0)
                {
                    max = sr;
                    Fb = Fsr;
                }
                else
                {
                    min = sr;
                    Fa = Fsr;
                }
            }
            Console.WriteLine(sr);
            Console.ReadKey();
        }
        static double F(double x)
        {
            return x * Math.Sin(Math.Log(x));
        }
    }
}
