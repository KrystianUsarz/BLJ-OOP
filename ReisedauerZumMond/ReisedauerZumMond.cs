using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

 namespace ReisedauerZumMond
{
    class ReisedauerZumMondBerechnung
    {
        int EntfernungMond = 384400;

        double geschwindigkeit;

        public double Geschwindigkeit 
        {
            get { return geschwindigkeit; }
            set { geschwindigkeit = value; }
        }

        public double ZeitWegZumMondStunden()
        {
            double resultatStunden = EntfernungMond / Geschwindigkeit;
            return resultatStunden;
        }

        public double ZeitWegZumMondTage()
        {
            double StundenWegMond = ZeitWegZumMondStunden();
            double resultatTage = StundenWegMond / 24;
            return resultatTage;
        }

    }
}
