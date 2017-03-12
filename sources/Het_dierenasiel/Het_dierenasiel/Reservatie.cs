using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Het_dierenasiel
{
    class Reservatie
    {
        private int reserveringsNummer;
        private Klant klant;
        private List<Kat> lijstKatten;
        private List<Hond> lijstHonden;
        

        public Reservatie(int reserveringsNummer)
        {

        }
        public void KatToevoegen(Kat kat)
        {
            lijstKatten.Add(kat);
        }
        public void HondToevoegen(Hond hond)
        {
            lijstHonden.Add(hond);
        }
        public List<Kat> AlleKatten()
        {
            return lijstKatten;
        }
        public List<Hond> AlleHonden()
        {
            return lijstHonden;
        }
    }
}
