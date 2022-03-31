using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace burgir
{

    public partial class Koszyk : Form
    {
        string koszykPrawdziwy;
        double lacznie;
        int randomLiczba;
        int iloscProb;
        bool czyBylaZnizka;
        string[] kody = { "MASNO", "BEN", "SPEED", "JERMA", "FORSEN" };
        string kod;
        bool wygrana;


        public Koszyk(string koszyk, double cenaZaWszystko)
        {
            InitializeComponent();
            koszykPrawdziwy = koszyk != "" ? koszyk : "W koszyku nic niema jeszcze";
            lacznie = cenaZaWszystko;
            randomLiczba = new Random().Next(1, 21);
            iloscProb = 5;
            kod = kody[new Random().Next(0, kody.Length)];
            MessageBox.Show(randomLiczba.ToString());
        }

        private void Koszyk_Load(object sender, EventArgs e)
        {
            lbRachunek.Text = koszykPrawdziwy;
            lbLacznie.Text = $@"Łącznie: {lacznie:F2} zł";
        }

        private void btnZgadnij_Click(object sender, EventArgs e)
        {
            if (iloscProb == 0 && !wygrana)
            {
                lbProby.Text = "";
                lbMaloDuzo.Text = "Wyczerpałeś/aś limit zgadywania.";
                wygrana = false;
                return;
            }
            if (wygrana)
            {
                lbProby.Text = "";
                lbMaloDuzo.Text = $"Wygrałeś promo kod: {kod}";
                return;
            }

            int proba = Convert.ToInt32(numProba.Value);


            iloscProb--;
            lbProby.Text = $"Zostało {iloscProb} prób";

            sprawdzCzyWygrana(proba);

            
        }
        private void sprawdzCzyWygrana(int proba)
        {
            if (proba == randomLiczba)
            {
                lbProby.Text = "";
                lbMaloDuzo.Text = $"Wygrałeś promo kod: {kod}";
                lbMaloDuzo.ForeColor = Color.Green;
                wygrana = true;
            }
            else if (proba > randomLiczba)
            {
                lbMaloDuzo.Text = "Za dużo!";
                lbMaloDuzo.ForeColor = Color.Red;
            }
            else if (proba < randomLiczba)
            {
                lbMaloDuzo.Text = "Za mało!";
                lbMaloDuzo.ForeColor = Color.Red;
            }
        }

        private void txtPromoKod_TextChanged(object sender, EventArgs e)
        {
            if (txtPromoKod.Text == kod)
            {
                lacznie *= 0.9;
                lbLacznie.Text = $@"Łącznie: {lacznie:F2} zł (po zniżce 10%)";
                czyBylaZnizka = true;
            } else if (czyBylaZnizka)
            {
                lacznie = ( lacznie * 100 ) / 90;
                lbLacznie.Text = $@"Łącznie: {lacznie:F2} zł";
                czyBylaZnizka = false;
            }
        }
    }
}
