using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace burgir
{
    

    public partial class Form1 : Form
    {
        public class Burger
        {
            public double cena { get; set; }
            public string nazwa { get; set; }
        }

        List<Burger> koszyk = new List<Burger>();
        public Form1()
        {
            InitializeComponent();
        }

        private void ObslugaDodaniaDoKoszyka(string nazwa_, double cena_) 
        {
            koszyk.Add(new Burger() { cena = cena_, nazwa = nazwa_ });
            
            
        }

        private void btnDodajDoKosz1_Click(object sender, EventArgs e)
        {
            
            ObslugaDodaniaDoKoszyka(lbBurga1.Text, Convert.ToDouble(cena1.Text.Split(" ")[0]));
            
        }
        private void btnDodajDoKosz2_Click(object sender, EventArgs e)
        {
            ObslugaDodaniaDoKoszyka(lbBurga2.Text, Convert.ToDouble(cena2.Text.Split(" ")[0]));
        }

        private void btnDodajDoKosz3_Click(object sender, EventArgs e)
        {
            ObslugaDodaniaDoKoszyka(lbBurga3.Text, Convert.ToDouble(cena3.Text.Split(" ")[0]));
        }
        private void btnDodajDoKosz4_Click(object sender, EventArgs e)
        {
            ObslugaDodaniaDoKoszyka(lbBurga4.Text, Convert.ToDouble(cena4.Text.Split(" ")[0]));
        }

        private void btnDodajDoKosz5_Click(object sender, EventArgs e)
        {
            ObslugaDodaniaDoKoszyka(lbBurga5.Text, Convert.ToDouble(cena5.Text.Split(" ")[0]));
        }

        private void btnDodajDoKosz6_Click(object sender, EventArgs e)
        {
            ObslugaDodaniaDoKoszyka(lbBurga6.Text, Convert.ToDouble(cena6.Text.Split(" ")[0]));
        }

        

        



    }
}
