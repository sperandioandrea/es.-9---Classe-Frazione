using System;
using System.Collections.Generic;
using System.Linq;
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
        public Frazione()
        {
            numeratore = 0;
            denominatore = 0;
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



    }
    
}
