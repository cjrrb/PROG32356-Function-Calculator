using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.MathFunctions
{
    internal class MathFunctions
    {
        public static double Sin(double theta)
        {
            return Math.Sin(2 * theta); 
        }

        public static double Cos(double theta)
        {
            return Math.Cos(3 * theta);
        }

        public static double Tan(double theta)
        {
            return Math.Tan(theta);
        }

        public static double Log(double theta)
        {
            return Math.Log(theta);
        }

        public static double Exp(double theta)
        {
            return Math.Exp(theta);
        }
    }
}
