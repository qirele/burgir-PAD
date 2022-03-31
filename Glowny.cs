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
    

    public partial class Glowny : Form
    {
        public class Burger
        {
            public double cena { get; set; }
            public string nazwa { get; set; }
            
        }
        public static List<Burger> koszyk;


        public Glowny()
        {
            InitializeComponent();
            
        }
        private void Glowny_Load(object sender, EventArgs e)
        {
            koszyk = new List<Burger>();
        }

        private void ObslugaDodaniaDoKoszyka(string nazwa_, double cena_) 
        {
            koszyk.Add(new Burger() { cena = cena_, nazwa = nazwa_ });
            
            
        }

        private void btnDodajDoKosz1_Click(object sender, EventArgs e)
        {
            
            ObslugaDodaniaDoKoszyka(lbBurga1.Text, double.Parse(cena1.Text.Replace(" zł", "")));
            
        }
        private void btnDodajDoKosz2_Click(object sender, EventArgs e)
        {
            ObslugaDodaniaDoKoszyka(lbBurga2.Text, double.Parse(cena2.Text.Replace(" zł", "")));
        }

        private void btnDodajDoKosz3_Click(object sender, EventArgs e)
        {
            ObslugaDodaniaDoKoszyka(lbBurga3.Text, double.Parse(cena3.Text.Replace(" zł", "")));
        }
        private void btnDodajDoKosz4_Click(object sender, EventArgs e)
        {
            ObslugaDodaniaDoKoszyka(lbBurga4.Text, double.Parse(cena4.Text.Replace(" zł", "")));
        }

        private void btnDodajDoKosz5_Click(object sender, EventArgs e)
        {
            ObslugaDodaniaDoKoszyka(lbBurga5.Text, double.Parse(cena5.Text.Replace(" zł", "")));
        }

        private void btnDodajDoKosz6_Click(object sender, EventArgs e)
        {
            ObslugaDodaniaDoKoszyka(lbBurga6.Text, double.Parse(cena6.Text.Replace(" zł", "")));
        }

        private void btnOtworzKoszyk_Click(object sender, EventArgs e)
        {
            string building = "";
            double cenaZaWszystko = 0;
            Dictionary<string, int> ileTegoBurgera = new Dictionary<string, int>();

            if (koszyk != null)
            {
                foreach (var burg in koszyk)
                {
                    building += $"{burg.nazwa}          {burg.cena} zł\n";
                    cenaZaWszystko += Convert.ToDouble(burg.cena);
                }

                // https://stackoverflow.com/questions/7832602/list-array-duplicates-with-count
                ileTegoBurgera = building.Split("\n").GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());

            }
               

            var koszykForm = new Koszyk(building, cenaZaWszystko, ileTegoBurgera);
            koszykForm.ShowDialog();
        }

        
    }
}
