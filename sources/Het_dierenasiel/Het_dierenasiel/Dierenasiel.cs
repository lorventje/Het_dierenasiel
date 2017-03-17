using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Het_dierenasiel
{
    public class Dierenasiel
    {
        public string dierenasielNaam { get; private set; }
        public string dierenasielLocatie { get; private set; }
        public List<Kat> aanwezigeKatten { get; private set; }
        public List<Hond> aanwezigeHonden { get; private set; }

        public Dierenasiel(string _dierenasielNaam, string _dierenasielLocatie)
        {
            dierenasielNaam = _dierenasielNaam;
            dierenasielLocatie = _dierenasielLocatie;
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
