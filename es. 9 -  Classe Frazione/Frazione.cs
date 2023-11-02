using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace es._9____Classe_Frazione
{
    class Frazione
    {
        //Attributi
        private int numeratore;
        private int denominatore;
        //other = frazione2
        //costruttore
        public Frazione(int numeratore, int denominatore)
        {
            this.numeratore = numeratore;
            this.denominatore = denominatore;
        }
        //creazione 2° oggetto (2° frazione)
        public Frazione(Frazione frazione2)
        {
            this.numeratore = frazione2.numeratore;
            this.denominatore = frazione2.denominatore;
        }
        //metodo Clone
        public Frazione Clone()
        {
            return new Frazione(this);
        }

        /*/metodi Get e Set
        public int Numeratore
        {
            get { return numeratore; }
            set { numeratore = value; }
        }
        public int Denominatore
        {
            get { return denominatore; }
            set { denominatore = value; }
        }/*/

        //Funzione MCD per la funzione SemplificaRrazione
        public int MCD(int a, int b)
        {
            while(b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        //Funzione semplifica frazione
        public void SemplificaFrazione()
        {
            int mcd = MCD(numeratore, denominatore);
            numeratore /= mcd;
            denominatore /= mcd;
        }

        //Funzione Somma
        public void Somma()
        {

        }

    }
    
}
