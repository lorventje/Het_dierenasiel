using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Het_dierenasiel
{
    public class Reservering
    {
        
        public int reserveringsNummer { get; private set; }
        public DateTime reserveringsDatum { get; private set; }
        public Klant klant { get; private set; }
        public List<Huisdier> lijstGereserveerdeHuisdieren = new List<Huisdier>();

        public Reservering(int reserveringsnummer, DateTime reserveringsDatum)
        {
            this.reserveringsNummer = reserveringsnummer;
            this.reserveringsDatum = reserveringsDatum;
        }

        public void KatToevoegen(Kat kat)
        {
            lijstGereserveerdeHuisdieren.Add(kat);
        }
        public void HondToevoegen(Hond hond)
        {
            lijstGereserveerdeHuisdieren.Add(hond);
        }
        public void HuisdierVerwijderen(Huisdier huisdier)
        {
            lijstGereserveerdeHuisdieren.Remove(huisdier);
        }
    }
}
