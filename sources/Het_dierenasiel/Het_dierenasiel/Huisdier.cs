using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Het_dierenasiel
{
    public abstract class Huisdier : IVerkoopbaar
    {
        public string Naam { get; set; }
        public string Soort { get; private set; }
        public Reservering Reservering { get; private set; }
        public Dierenasiel Dierenasiel { get; private set; }
        public abstract decimal Prijs { get; set; }


        public Huisdier(string _naam, string _soort)
        {
            this.Naam = _naam;
            this.Soort = _soort;
                
        }
        public Boolean Gereserveerd(int reserveringsnummer)
        {
            if(this.Reservering == null)
            {
                this.Reservering = new Reservering(15, DateTime.Now);
                return true;
            }
            return false;
        }


        public override string ToString()
        {
            return Naam;
        }
    }
}
