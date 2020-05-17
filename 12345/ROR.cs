using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12345
{
    class ROR : IOperacje
    {
        private double saldo;

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public void Wplata(double wplata) {
            this.saldo += wplata;
        }

        public void Odsetki() {
            if (this.saldo > 0) {
                this.saldo += 5;
            }

            if (this.saldo < 0) {
                this.saldo -= 10;
            }
        }
    
    }
}
