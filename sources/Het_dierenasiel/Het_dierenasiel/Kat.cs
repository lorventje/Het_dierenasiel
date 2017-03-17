using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Het_dierenasiel
{
    public class Kat : Huisdier
    {
        public string katGewoonte { get; private set; }

        public Kat(string naam, string soort, string status, string gewoonte) :base(naam,soort,status)
        {
            this.katGewoonte = gewoonte;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
