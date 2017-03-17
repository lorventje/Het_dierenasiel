using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Het_dierenasiel
{
    public class Huisdier
    {
        public string naam { get; private set; }
        public string soort { get; private set; }
        public string status { get; private set; }
        public Reservatie reservering { get; private set; }
        public Dierenasiel dierenasiel { get; private set; }
        public Huisdier(string naam, string soort, string status)
        {
            this.naam = naam;
            this.soort = soort;
            this.status = status;
        }
        public Boolean GereserveerdZijn(Reservatie reservatie)
        {
            return true;
        }
    }
}
