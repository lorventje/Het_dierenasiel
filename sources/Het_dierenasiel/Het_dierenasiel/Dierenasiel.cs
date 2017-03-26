using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Het_dierenasiel
{
    public class Dierenasiel
    {
        public string dierenasielNaam { get; private set; }
        public string dierenasielLocatie { get; private set; }
        public List<Huisdier> aanwezigeHuisdieren = new List<Huisdier>();
        public List<Hond> hondjes = new List<Hond>();
    

        public Dierenasiel(string _dierenasielNaam, string _dierenasielLocatie)
        {
            dierenasielNaam = _dierenasielNaam;
            dierenasielLocatie = _dierenasielLocatie;
        }
        public void KatToevoegen(Kat kat)
        {
            aanwezigeHuisdieren.Add(kat);
        }
        public void HondToevoegen(Hond hond)
        {
            aanwezigeHuisdieren.Add(hond);
        }
        public void HuisdierVerwijderen(Huisdier huisdier)
        {
            aanwezigeHuisdieren.Remove(huisdier);
        }
        

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
