using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Het_dierenasiel
{
    public class Klant
    {
        public string klantNaam { get; private set; }
        public string klantAdres { get; private set; }
        public int klantTelefoonnummer { get; private set; }
        public int reservatieNummer { get; private set; }
        public List<Reservatie> reserveringsLijst { get; private set; }

        public Klant(string klantNaam, string klantAdres, int klantTelefoonnummer)
        {
            this.klantNaam = klantNaam;
            this.klantAdres = klantAdres;
            this.klantTelefoonnummer = klantTelefoonnummer;
        }
        public void ReserveringToevoegen(Reservatie reservering)
        {
            reserveringsLijst.Add(reservering);
        }
    }
}
