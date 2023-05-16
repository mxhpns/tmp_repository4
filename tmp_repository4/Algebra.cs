using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tmp_repository4 {
    internal class Algebra {
        public double naturalLog(double num) {
            return Math.Log(num);
        }
        public double Log(double num, double newBase) {
            return Math.Log(num,newBase); 
        }
    }
}
