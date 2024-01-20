using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ampelprojekt_IFS12
{
    class Ampel_Steuerung
    {
        // 0=aus; 1=gelb; 2=rot; 3=rotgelb; 4=grün
        private int Zustand = 0;
        private Ampel_Form Ampelformular = new Ampel_Form();
        
        public Ampel_Steuerung(int x, int y)
        {
            // Konstruktor
           
        }
         
        public void einschalten()
        {
            //
            if(this.Zustand == 0)
            {
                this.Zustand = 1;
                Ampelformular.GelbEin();
            }
        }
        public void ausschalten()
        {
            //
            if(this.Zustand == 1)
            {
                this.Zustand = 0;
                Ampelformular.GelbAus();
            }
        }

        public void umschalten()
        {
            //
            if(this.Zustand > 0)
            {
                switch(this.Zustand)
                {
                    //Gelb -> Rot
                    case 1:
                        {
                            this.Ampelformular.GelbAus();
                            this.Ampelformular.RotEin();
                            this.Zustand = 2;
                            break;
                        }
                    //Rot -> RotGelb
                    case 2:
                        {
                            this.Ampelformular.GelbEin();
                            this.Zustand = 3;
                            break;
                        }
                    //RotGelb -> Gruen
                    case 3:
                        {
                            this.Ampelformular.RotAus();
                            this.Ampelformular.GelbAus();
                            this.Ampelformular.GruenEin();
                            this.Zustand = 4;
                            break;
                        }
                    //Gruen -> Gelb
                    case 4:
                        {
                            this.Ampelformular.GruenAus();
                            this.Ampelformular.GelbEin();
                            this.Zustand = 1;
                            break;
                        }
                    //Catch error
                    default:
                        {
                            this.Ampelformular.GruenEin();
                            this.Ampelformular.GelbEin();
                            this.Ampelformular.RotEin();
                            break;
                        }
                }
            }
            
        }
    }
}
