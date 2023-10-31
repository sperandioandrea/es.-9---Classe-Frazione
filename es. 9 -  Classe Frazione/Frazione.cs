using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace es._9____Classe_Frazione
{
    class Frazione
    {
        //Attributi
        private int numeratore;
        private int denominatore;

        //costruttore
        public Frazione(int numeratore, int denominatore)
        {
            Numeratore = numeratore;
            Denominatore = denominatore;
        }
        //metodi Get e Set
        public int Numeratore
        {
            get { return numeratore; }
            set { numeratore = value; }
        }
        public int Denominatore
        {
            get { return denominatore; }
            set { denominatore = value; }
        }
        //Funzione MCD per la funzione SemplificaRrazione
        private int MCD(int a, int b)
        {
            if (b == 0)
            return a;
            return MCD(b, a % b);
        }
        //Funzione semplifica frazione
        public void SemplificaFrazione()
        {
            int mcd = MCD(Numeratore, Denominatore);
            Numeratore /= mcd;
            Denominatore /= mcd;
        }
    }
    
}
