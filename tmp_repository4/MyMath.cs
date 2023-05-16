using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tmp_repository4
{
    internal class MyMath
    {
        public static double add(double numberA, double numberB)
        {
            return numberA + numberB;
        }
        public static double sub(double numberA, double numberB)
        {
            return numberA - numberB;
        }
        public static double mul(double numberA, double numberB)
        {
            return numberA * numberB;
        }
        public static double div(double numberA, double numberB)
        {
            try
            {
                return numberA / numberB;
            }
            catch (Exception)
            {
                return 0;
            }          
        }
    }
}
