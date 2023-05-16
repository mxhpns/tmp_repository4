using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tmp_repository4 {
    internal class Algebra {
        public double naturalLog(double num) {
            double log = Math.Log(num);
            return log;
        }
        public double Log(double num, double newBase) {
            double log = Math.Log(num,newBase);
            return log;
        }
    }
}
