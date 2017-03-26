using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Het_dierenasiel
{
    public class Product : IVerkoopbaar
    {
        public string Naam { get; set; }
        public decimal Prijs { get; set; }

        public Product(string naam, decimal prijs)
        {
            this.Naam = naam;
            this.Prijs = prijs;
        }
        public override string ToString()
        {
            return Naam + " " + Prijs;
        }
    }
}
