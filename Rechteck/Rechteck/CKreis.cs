using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechteck
{
    class CKreis
    {
        private double Radius = 1.0;

        public CKreis()
        {

        }

        public CKreis(double neuRadius)
        {
            this.setRadius(neuRadius);
        }
        public bool setRadius(double neuRadius)
        {
            if (neuRadius <= 0.0)
            {
                return false;
            }
            else
            {
                this.Radius = neuRadius;
                return true;
            }
        }

        public double getRadius()
        {
            return this.Radius;
        }

        public double Flaeche()
        {
            double d_flaeche;
            d_flaeche = Math.PI * this.getRadius() * 2;

            return d_flaeche;
        }

        public double Umfang()
        {
            double d_umfang;
            d_umfang = Math.PI * (this.getRadius() * this.getRadius());

            return d_umfang;
        }
    }
}
