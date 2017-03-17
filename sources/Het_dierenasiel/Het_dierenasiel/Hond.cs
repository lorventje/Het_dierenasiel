using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Het_dierenasiel
{
    public class Hond : Huisdier 
    {

        public DateTime hondUitlaatDatum { get; private set; }

        public Hond(string naam, string soort, string status, DateTime hondUitlaatDatum) :base(naam, soort, status)
        {
            this.hondUitlaatDatum = hondUitlaatDatum;
        }

        public void UitlaatDatumToevoegen(DateTime uitlaatDatum)
        {
            this.hondUitlaatDatum = uitlaatDatum;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
