using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Het_dierenasiel
{
    class Kat
    {
        private string katNaam;
        private string katSoort;
        private string katStatus;
        private string katGewoonte;
        private Reservatie reservering;
        private Dierenasiel dierenasiel;

        public Kat(string katNaam, string katSoort, string katStatus, string katGewoonte)
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
