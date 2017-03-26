using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Het_dierenasiel
{
    public partial class Form1 : Form
    {
        Webshop webshop = new Webshop();
        Dierenasiel dierenasiel = new Dierenasiel("OpvangTeDier", "Haarlem");
        Reservering reservering = new Reservering(27, DateTime.Now);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnProductToevoegen_Click(object sender, EventArgs e)
        {
            lbProductenLijst.DataSource = null;
            Product product = new Product(tbNaam.Text, Convert.ToDecimal(tbPrijs.Text));
            webshop.lijstProducten.Add(product);
            lbProductenLijst.DataSource = webshop.lijstProducten; 
        }
        private void btnProductKopen_Click(object sender, EventArgs e)
        {
            int selectedItemIndex;
            selectedItemIndex = lbProductenLijst.SelectedIndex;
            MessageBox.Show("Verkocht product: " + webshop.lijstProducten[selectedItemIndex].ToString());

            lbProductenLijst.DataSource = null;
            lbVerkochteProducten.DataSource = null;

            Product product = new Product(webshop.lijstProducten[selectedItemIndex].Naam, webshop.lijstProducten[selectedItemIndex].Prijs);
            webshop.lijstVerkochteProducten.Add(product);

            webshop.lijstProducten.RemoveAt(selectedItemIndex);

            lbProductenLijst.DataSource = webshop.lijstProducten;
            lbVerkochteProducten.DataSource = webshop.lijstVerkochteProducten;
        }
        private void btnHondToevoegen_Click(object sender, EventArgs e)
        {
            lbDierenasiel.DataSource = null;
            dierenasiel.HondToevoegen(new Hond(tbNamen.Text, tbSoort.Text, new DateTime(Convert.ToInt32(tbUitlaatDatumy.Text), Convert.ToInt32(tbUitlaatDatumm.Text), Convert.ToInt32(tbUitlaatDatumd.Text))));
            lbDierenasiel.DataSource = dierenasiel.aanwezigeHuisdieren;
            Hond.hondelijsie.Add(new Hond("1", "2", new DateTime(2008)));
        }
        private void btnKatToevoegen_Click(object sender, EventArgs e)
        {
            lbDierenasiel.DataSource = null;
            dierenasiel.KatToevoegen(new Kat(tbNamen.Text, tbSoort.Text, tbGewoonte.Text));
            lbDierenasiel.DataSource = dierenasiel.aanwezigeHuisdieren;
        }
        private void btnHuisdierReserveren_Click(object sender, EventArgs e)
        {
            int selectedItemIndex;
            selectedItemIndex = lbDierenasiel.SelectedIndex;

            reservering.lijstGereserveerdeHuisdieren.Add(dierenasiel.aanwezigeHuisdieren[selectedItemIndex]);
            dierenasiel.aanwezigeHuisdieren.RemoveAt(selectedItemIndex);

            lbReserveringsLijst.DataSource = null;
            lbDierenasiel.DataSource = null;
            lbReserveringsLijst.DataSource = reservering.lijstGereserveerdeHuisdieren;
            lbDierenasiel.DataSource = dierenasiel.aanwezigeHuisdieren;
        }
        private void btnHuisdierVerwijderen_Click(object sender, EventArgs e)
        {
            int selectedItemIndex;
            selectedItemIndex = lbDierenasiel.SelectedIndex;
            dierenasiel.HuisdierVerwijderen(dierenasiel.aanwezigeHuisdieren[selectedItemIndex]);
            lbDierenasiel.DataSource = null;
            lbDierenasiel.DataSource = dierenasiel.aanwezigeHuisdieren;

            Hond.hondelijsie.Remove(Hond.hondelijsie[0]);
        }

        private void btnReservatieKopen_Click(object sender, EventArgs e)
        {
            foreach(Huisdier diertje in reservering.lijstGereserveerdeHuisdieren)
            {
                MessageBox.Show(diertje.Prijs.ToString());
            } 
        }
    }
}
