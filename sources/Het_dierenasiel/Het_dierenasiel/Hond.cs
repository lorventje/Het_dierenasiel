using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Het_dierenasiel
{
    class Hond
    {
        private string hondNaam;
        private string hondSoort;
        private string hondStatus;
        private DateTime hondUitlaatDatum;
        private Reservatie reservering;
        private Dierenasiel dierenasiel;

        public Hond(string hondNaam, string hondSoort, string hondStatus)
        {

        }

        public void UitlaatDatumToevoegen(DateTime uitlaatDatum)
        {

        }

        public Boolean GereserveerdZijn(Reservatie reserveringsNummer)
        {
            return true;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
