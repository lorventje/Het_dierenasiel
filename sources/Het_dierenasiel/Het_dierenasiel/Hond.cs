using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Het_dierenasiel
{
    public class Hond : Huisdier 
    {
        public static List<Hond> hondelijsie = new List<Hond>();
        private decimal prijs;

        public DateTime hondUitlaatDatum { get; private set; }
        public bool UitlaatBehoefte
        {
            get
            {
                return (DateTime.Today - this.hondUitlaatDatum).Days > 0;
            }
        }


        public Hond(string naam, string soort, DateTime hondUitlaatDatum) :base(naam, soort)
        {
            
            this.hondUitlaatDatum = hondUitlaatDatum;
            if(hondelijsie.Count <= 0)
            {
                prijs = 500;
            }
            else
            {
                prijs = (500 - (hondelijsie.Count * 50));
            }
            this.Prijs = prijs;
        }
        public void UitlaatDatumToevoegen(DateTime uitlaatDatum)
        {
            this.hondUitlaatDatum = uitlaatDatum;
        }



        public override string ToString()
        {
            return base.ToString();
        }
        public override decimal Prijs { get; set; }

    }
}
