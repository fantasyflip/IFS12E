using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Rechteck
{
    class CRechteck
    {
        private double a = 1.0;
        private double b = 1.0;

        public CRechteck()
        {

        }

        public CRechteck(double neuA, double neuB)
        {
            this.setSeitenlaengen(neuA, neuB);
        }

        public bool setSeitenlaengen(double neuA, double neuB)
        {
            if ((neuA <= 0.0)||(neuB <= 0.0))
            {
                return false;
            }
            else
            {
                this.a = neuA;
                this.b = neuB;
                return true;
            }
        }

        public double getA()
        {
            return this.a;
        }

        public double getB()
        {
            return this.b;
        }

        public double Flaeche()
        {
            double d_flaeche = this.getA() * this.getB();
            return d_flaeche;
        }

        public double Umfang()
        {
            double d_umfang = 2 * (this.getA() + this.getA());
            return d_umfang;
        }
    }
}
