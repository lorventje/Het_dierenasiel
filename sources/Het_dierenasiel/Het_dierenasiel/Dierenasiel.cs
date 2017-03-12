using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Het_dierenasiel
{
    class Dierenasiel
    {
        private string dierenasielNaam;
        private string dierenasielLocatie;
        private List<Kat> aanwezigeKatten;
        private List<Hond> aanwezigeHonden;

        public Dierenasiel(string dierenasielNaam, string dierenasielLocatie)
        {

        }

        public void KatToevoegen(Kat kat)
        {
            aanwezigeKatten.Add(kat);
        }
        public void HondToevoegen(Hond hond)
        {
            aanwezigeHonden.Add(hond);
        }
        public void KatVerwijderen(Kat kat)
        {
            aanwezigeKatten.Remove(kat);
        }
        public void HondVerwijderen(Hond hond)
        {
            aanwezigeHonden.Remove(hond);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
