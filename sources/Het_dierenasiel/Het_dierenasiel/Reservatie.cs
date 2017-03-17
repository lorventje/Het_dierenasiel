using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Het_dierenasiel
{
    public class Reservatie
    {
        
        public int reserveringsNummer { get; private set; }
        public Klant klant { get; private set; }
        public List<Huisdier>lijstHuisdieren { get; private set; }

        
        public Reservatie(int reserveringsNummer)
        {
            this.reserveringsNummer = reserveringsNummer;
        }
        public void KatToevoegen(Kat kat)
        {
            lijstHuisdieren.Add(kat);
        }
        public void HondToevoegen(Hond hond)
        {
            lijstHuisdieren.Add(hond);
        }
        public List<Huisdier> AlleHuisdieren()
        {
            return lijstHuisdieren;
        }
    }
}
