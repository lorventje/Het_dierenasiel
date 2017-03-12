using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Het_dierenasiel
{
    class Klant
    {
        private string klantNaam;
        private string klantAdres;
        private int klantTelefoonnummer;
        private int reservatieNummer;
        private List<Reservatie> reserveringsLijst;

        public Klant(string klantNaam, string klantAdres, int klantTelefoonnummer)
        {
            
        }
        public void ReserveringToevoegen(Reservatie reservering)
        {
            reserveringsLijst.Add(reservering);
        }
    }
}
