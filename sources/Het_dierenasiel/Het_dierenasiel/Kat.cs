using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Het_dierenasiel
{
    public class Kat : Huisdier
    {
        private decimal prijs;
        public string katGewoonte { get; set; }
        public override decimal Prijs { get; set; }


        public Kat(string naam, string soort, string gewoonte) :base(naam,soort)
        {
            this.katGewoonte = gewoonte;
            if(katGewoonte.Length > 15)
            {
                prijs = 35;
            }
            else
            {
                prijs = (350 - (katGewoonte.Length * 20));
            }
            this.Prijs = prijs;
        }


        public override string ToString()
        {
            return base.ToString();
        }

    }
}
