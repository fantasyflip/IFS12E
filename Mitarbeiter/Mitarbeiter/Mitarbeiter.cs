using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mitarbeiter
{
    // abstrakte Basisklasse 
    public abstract class CMitarbeiter 
    {
        private String Vorname;
        private String Nachname;

        public void setVorname(String neuVorname)
        {
            this.Vorname = neuVorname;
        }

        public String getVorname()
        {
            return this.Vorname;
        }

        public void setNachname(String neuNachname)
        {
            this.Nachname = neuNachname;
        }

        public String getNachname()
        {
            return this.Nachname;
        }
    }

    // Weitere Klassen
    public class CAngestellter : CMitarbeiter
    {
        private double Bruttogehalt;

        public CAngestellter()
        {
            
        }

        public CAngestellter(String neuVorname, String neuNachname, double neuBrutto)
        {
            this.setVorname(neuVorname);
            this.setNachname(neuNachname);
            this.setBrutto(neuBrutto);
        }

        public void setBrutto(double neuBrutto)
        {
            this.Bruttogehalt = neuBrutto;
        }

        public double getBrutto()
        {
            return this.Bruttogehalt;
        }
    }

    public class CArbeiter : CMitarbeiter
    {
        private double Stundenzahl;
        private double Stundenlohn;

        public CArbeiter()
        {

        }

        public CArbeiter(String neuVorname, String neuNachname, double neuStundenzahl, double neuStundenlohn)
        {
            this.setVorname(neuVorname);
            this.setNachname(neuNachname);
            this.setStundenzahl(neuStundenzahl);
            this.setStundenlohn(neuStundenlohn);
        }

        public double getBrutto()
        {
            return this.Stundenlohn * this.Stundenzahl;
        }

        public void setStundenzahl(double neuAnzahl)
        {
            this.Stundenzahl = neuAnzahl;
        }

        public void setStundenlohn(double neuLohn)
        {
            this.Stundenlohn = neuLohn;
        }
    }

}
