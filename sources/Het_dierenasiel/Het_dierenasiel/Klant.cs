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
        public string klantWoonplaats { get; private set; }
        public int klantTelefoonnummer { get; private set; }
        public int reserveringsNummer { get; private set; }
        public List<Reservering> reserveringsLijst = new List<Reservering>();


        public Klant(string klantNaam, string klantWoonplaats, int klantTelefoonnummer)
        {
            this.klantNaam = klantNaam;
            this.klantWoonplaats = klantWoonplaats;
            this.klantTelefoonnummer = klantTelefoonnummer;
        }
        public void ReserveringToevoegen(Reservering reservering)
        {
            reserveringsLijst.Add(reservering);
        }
        public void ReserveringVerwijderen(Reservering reservering)
        {
            reserveringsLijst.Remove(reservering);
        }
    }
}
